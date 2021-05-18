using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class IdareciManager : IIdareciService
    {
        IIdareciDal _idareciDal;

        public IdareciManager(IIdareciDal idareciDal)
        {
            _idareciDal = idareciDal;
        }

        [ValidationAspect(typeof(IdareciValidator))]
        public IResult Add(IdareciForRegisterDto idareciForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(idareciForRegisterDto.Sifre, out passwordHash, out passwordSalt);

            var idareci = new Idareci
            {
                Isim = idareciForRegisterDto.Isim,
                Soyad = idareciForRegisterDto.Soyad,
                EMail = idareciForRegisterDto.EMail,
                Adres = idareciForRegisterDto.Adres,
                KayitTarihi = idareciForRegisterDto.KayitTarihi,
                TelefonNumarasi = idareciForRegisterDto.TelefonNumarasi,
                SaltSifre = passwordSalt,
                HashSifre = passwordHash,
                UnvanId = idareciForRegisterDto.UnvanId,
                FakulteId = idareciForRegisterDto.FakulteId,
                SicilNo = idareciForRegisterDto.SicilNo
            };

            var result = BusinessRules.Run(SicilNoKontrol(idareciForRegisterDto.SicilNo), EmailKontrol(idareciForRegisterDto.EMail),
                            TelefeonNoKontrol(idareciForRegisterDto.TelefonNumarasi));

            if (!result.Success)
            {
                return new ErrorResult("Hata");
            }

            _idareciDal.Add(idareci);
            return new Result(true, Messages.IdareciAdded);
        }

        public IResult Delete(int sicilNo)
        {
            var idareci = GetBySicilNo(sicilNo).Data;
            _idareciDal.Delete(idareci);
            return new Result(true, Messages.IdareciDeleted);
        }

        [ValidationAspect(typeof(IdareciValidator))]
        public IResult Update(IdareciForRegisterDto idareciForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(idareciForRegisterDto.Sifre, out passwordHash, out passwordSalt);

            var idareci = new Idareci
            {
                Isim = idareciForRegisterDto.Isim,
                Soyad = idareciForRegisterDto.Soyad,
                EMail = idareciForRegisterDto.EMail,
                Adres = idareciForRegisterDto.Adres,
                KayitTarihi = idareciForRegisterDto.KayitTarihi,
                TelefonNumarasi = idareciForRegisterDto.TelefonNumarasi,
                SaltSifre = passwordSalt,
                HashSifre = passwordHash,
                UnvanId = idareciForRegisterDto.UnvanId,
                FakulteId = idareciForRegisterDto.FakulteId,
                SicilNo = idareciForRegisterDto.SicilNo
            };

            var result = BusinessRules.Run(SicilNoKontrol(idareciForRegisterDto.SicilNo), EmailKontrol(idareciForRegisterDto.EMail),
                                        TelefeonNoKontrol(idareciForRegisterDto.TelefonNumarasi));

            if (!result.Success)
            {
                return new ErrorResult("Hata");
            }
            _idareciDal.Update(idareci);
            return new Result(true, Messages.IdareciUpdated);
        }

        public IDataResult<Idareci> Login(LoginDto LoginDto)
        {
            var idareciKontrol = GetBySicilNo(LoginDto.LoginNo).Data;
            if (idareciKontrol == null)
            {
                return new ErrorDataResult<Idareci>("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(LoginDto.Password, idareciKontrol.HashSifre, idareciKontrol.SaltSifre))
            {
                return new ErrorDataResult<Idareci>("Parola hatası");
            }

            return new SuccessDataResult<Idareci>(idareciKontrol, "Başarılı giriş");
        }
        public IDataResult<Idareci> GetById(int Id)
        {

            return new SuccessDataResult<Idareci>(_idareciDal.Get(a => a.Id == Id), Messages.IdareciGeted);
        }
        public IDataResult<List<Idareci>> GetAll()
        {
            return new SuccessDataResult<List<Idareci>>(_idareciDal.GetAll(), Messages.IdareciListed);
        }

        public IDataResult<Idareci> GetBySicilNo(int sicilNo)
        {
            return new SuccessDataResult<Idareci>(_idareciDal.Get(i => i.SicilNo == sicilNo), Messages.IdareciGeted);
        }

        public IDataResult<Idareci> GetByEMail(string email)
        {
            return new SuccessDataResult<Idareci>(_idareciDal.Get(i => i.EMail == email), Messages.IdareciGeted);
        }

        public IDataResult<List<Idareci>> GetByUnvanId(int Id)
        {
            return new SuccessDataResult<List<Idareci>>(_idareciDal.GetAll(i => i.UnvanId == Id), Messages.IdareciGeted);
        }

        public IDataResult<List<IdareciDetayDto>> GetAllByIdareciDto()
        {
            return new SuccessDataResult<List<IdareciDetayDto>>(_idareciDal.GetIdareciDetaylari(), Messages.IdareciListed);
        }
        private IResult SicilNoKontrol(int sicilNo)
        {
            var result = _idareciDal.GetAll(i => i.SicilNo == sicilNo).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        private IResult EmailKontrol(string email)
        {
            var result = _idareciDal.GetAll(i => i.EMail == email).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        private IResult TelefeonNoKontrol(string telefonNumarasi)
        {
            var result = _idareciDal.GetAll(i => i.TelefonNumarasi == telefonNumarasi).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

    }

}

