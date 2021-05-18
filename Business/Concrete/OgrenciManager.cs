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
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        [ValidationAspect(typeof(OgrenciValidator))]
        public IResult Add(OgrenciForRegisterDto ogrenciForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(ogrenciForRegisterDto.Sifre, out passwordHash, out passwordSalt);

            var ogrenci = new Ogrenci
            {
                Isim = ogrenciForRegisterDto.Isim,
                Soyad = ogrenciForRegisterDto.Soyad,
                EMail = ogrenciForRegisterDto.EMail,
                Adres = ogrenciForRegisterDto.Adres,
                KayitTarihi = ogrenciForRegisterDto.KayitTarihi,
                TelefonNumarasi = ogrenciForRegisterDto.TelefonNumarasi,
                SaltSifre = passwordSalt,
                HashSifre = passwordHash,
                UnvanId = ogrenciForRegisterDto.UnvanId,
                OgrenciNo = ogrenciForRegisterDto.OgrenciNo,
                MufredatId = ogrenciForRegisterDto.MufredatId,
                BolumId = ogrenciForRegisterDto.BolumId,
                AileAdres = ogrenciForRegisterDto.AileAdres,
                AileTelefon = ogrenciForRegisterDto.AileTelefon,
                BankaAdi = ogrenciForRegisterDto.BankaAdi,
                SubeAdi = ogrenciForRegisterDto.SubeAdi,
                SubeKodu = ogrenciForRegisterDto.SubeKodu,
                HesapNumarası = ogrenciForRegisterDto.HesapNumarası,
                IBAN = ogrenciForRegisterDto.IBAN,
                HesapSahibininAdiSoyadi = ogrenciForRegisterDto.HesapSahibininAdiSoyadi,
                DanismanId = ogrenciForRegisterDto.DanismanId
            };

            var result = BusinessRules.Run(OgrenciNoKontrol(ogrenciForRegisterDto.OgrenciNo), EmailKontrol(ogrenciForRegisterDto.EMail),
                TelefeonNoKontrol(ogrenciForRegisterDto.TelefonNumarasi));

            if (!result.Success)
            {
                return new ErrorResult("Hata");
            }

            _ogrenciDal.Add(ogrenci);
            return new Result(true, Messages.OgrenciAdded);
        }

        public IResult Delete(int ogrenciNo)
        {
            var ogrenci = GetByOgrenciNo(ogrenciNo).Data;
            _ogrenciDal.Delete(ogrenci);
            return new Result(true, Messages.OgrenciDeleted); 
        }

        [ValidationAspect(typeof(OgrenciValidator))]
        public IResult Update(OgrenciForRegisterDto ogrenciForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(ogrenciForRegisterDto.Sifre, out passwordHash, out passwordSalt);

            var ogrenci = new Ogrenci
            {
                Isim = ogrenciForRegisterDto.Isim,
                Soyad = ogrenciForRegisterDto.Soyad,
                EMail = ogrenciForRegisterDto.EMail,
                Adres = ogrenciForRegisterDto.Adres,
                KayitTarihi = ogrenciForRegisterDto.KayitTarihi,
                TelefonNumarasi = ogrenciForRegisterDto.TelefonNumarasi,
                SaltSifre = passwordSalt,
                HashSifre = passwordHash,
                UnvanId = ogrenciForRegisterDto.UnvanId,
                OgrenciNo = ogrenciForRegisterDto.OgrenciNo,
                MufredatId = ogrenciForRegisterDto.MufredatId,
                BolumId = ogrenciForRegisterDto.BolumId,
                AileAdres = ogrenciForRegisterDto.AileAdres,
                AileTelefon = ogrenciForRegisterDto.AileTelefon,
                BankaAdi = ogrenciForRegisterDto.BankaAdi,
                SubeAdi = ogrenciForRegisterDto.SubeAdi,
                SubeKodu = ogrenciForRegisterDto.SubeKodu,
                HesapNumarası = ogrenciForRegisterDto.HesapNumarası,
                IBAN = ogrenciForRegisterDto.IBAN,
                HesapSahibininAdiSoyadi = ogrenciForRegisterDto.HesapSahibininAdiSoyadi,
                DanismanId = ogrenciForRegisterDto.DanismanId
            };

            var result = BusinessRules.Run(OgrenciNoKontrol(ogrenciForRegisterDto.OgrenciNo), EmailKontrol(ogrenciForRegisterDto.EMail),
                            TelefeonNoKontrol(ogrenciForRegisterDto.TelefonNumarasi));

            if (!result.Success)
            {
                return new ErrorResult("Hata");
            }

            _ogrenciDal.Update(ogrenci);
            return new Result(true, Messages.OgrenciUpdated);
        }

        public IDataResult<Ogrenci> Login(LoginDto LoginDto)
        {
            var ogrenciKontrol = GetByOgrenciNo(LoginDto.LoginNo).Data;
            if (ogrenciKontrol == null)
            {
                return new ErrorDataResult<Ogrenci>("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(LoginDto.Password, ogrenciKontrol.HashSifre, ogrenciKontrol.SaltSifre))
            {
                return new ErrorDataResult<Ogrenci>("Parola hatası");
            }

            return new SuccessDataResult<Ogrenci>(ogrenciKontrol, "Başarılı giriş");
        }

        public IDataResult<List<Ogrenci>> GetAll()
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(), Messages.OgrenciListed); 
        }

        public IDataResult<Ogrenci> GetByOgrenciNo(int ogrenciNo)
        {
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(o => o.OgrenciNo == ogrenciNo), Messages.OgrenciGeted); 
        }

        public IDataResult<List<Ogrenci>> GetByBolumId(int Id)
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(o => o.BolumId == Id), Messages.OgrenciGeted);
        }

        public IDataResult<List<Ogrenci>> GetByDanismanId(int Id)
        {
            return new SuccessDataResult<List<Ogrenci>>(_ogrenciDal.GetAll(o => o.DanismanId == Id), Messages.OgrenciGeted);
        }

        public IDataResult<Ogrenci> GetByEMail(string email)
        {
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(o => o.EMail == email), Messages.OgrenciGeted);
        }

        public IDataResult<Ogrenci> GetById(int Id)
        {
            return new SuccessDataResult<Ogrenci>(_ogrenciDal.Get(o => o.Id == Id), Messages.OgrenciGeted);
        }

        public IDataResult<List<OgrenciDetayDto>> GetAllByOgrenciDto()
        {
            return new SuccessDataResult<List<OgrenciDetayDto>>(_ogrenciDal.GetOgrenciDetaylari(), Messages.OgrenciListed);
        }

        private IResult OgrenciNoKontrol(int ogrenciNo)
        {
            var result = _ogrenciDal.GetAll(i => i.OgrenciNo == ogrenciNo).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        private IResult EmailKontrol(string email)
        {
            var result = _ogrenciDal.GetAll(i => i.EMail == email).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        private IResult TelefeonNoKontrol(string telefonNumarasi)
        {
            var result = _ogrenciDal.GetAll(i => i.TelefonNumarasi == telefonNumarasi).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }
    }

}

