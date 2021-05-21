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
                return new ErrorResult(result.Message);
            }

            _ogrenciDal.Add(ogrenci);
            return new Result(true, Messages.OgrenciAdded);
        }

        public IResult Delete(int ogrenciNo)
        {
            var ogrenci = _ogrenciDal.Get(o => o.OgrenciNo == ogrenciNo);
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
                return new ErrorResult(result.Message);
            }

            _ogrenciDal.Update(ogrenci);
            return new Result(true, Messages.OgrenciUpdated);
        }

        public IDataResult<Ogrenci> Login(LoginDto LoginDto)
        {
            var ogrenciKontrol = _ogrenciDal.Get(o => o.OgrenciNo == LoginDto.LoginNo);
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

        public IDataResult<List<OgrenciDetayDto>> GetByOgrenciNo(int ogrenciNo)
        {
            return new SuccessDataResult<List<OgrenciDetayDto>>(_ogrenciDal.GetOgrenciDetaylari(o => o.OgrenciNo == ogrenciNo), Messages.OgrenciGeted); 
        }

        public IDataResult<List<OgrenciDetayDto>> GetByBolumId(int Id)
        {
            return new SuccessDataResult<List<OgrenciDetayDto>>(_ogrenciDal.GetOgrenciDetaylari(o => o.BolumId == Id), Messages.OgrenciGeted);
        }

        public IDataResult<List<OgrenciDetayDto>> GetByDanismanId(int Id)
        {
            return new SuccessDataResult<List<OgrenciDetayDto>>(_ogrenciDal.GetOgrenciDetaylari(o => o.DanismanId == Id), Messages.OgrenciGeted);
        }

        public IDataResult<List<OgrenciDetayDto>> GetByEMail(string email)
        {
            return new SuccessDataResult<List<OgrenciDetayDto>>(_ogrenciDal.GetOgrenciDetaylari(o => o.EMail == email), Messages.OgrenciGeted);
        }

        public IDataResult<List<OgrenciDetayDto>> GetById(int Id)
        {
            return new SuccessDataResult<List<OgrenciDetayDto>>(_ogrenciDal.GetOgrenciDetaylari(o => o.Id == Id), Messages.OgrenciGeted);
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

            return new ErrorResult("Bu ogrenci numarasına ait ogrenci var");
        }

        private IResult EmailKontrol(string email)
        {
            var result = _ogrenciDal.GetAll(i => i.EMail == email).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult("Bu emaile ait ogrenci var");
        }

        private IResult TelefeonNoKontrol(string telefonNumarasi)
        {
            var result = _ogrenciDal.GetAll(i => i.TelefonNumarasi == telefonNumarasi).Count();
            if (result == 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult("Bu telefon numarasına ait ogrenci var");
        }
    }

}

