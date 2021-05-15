using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MailManager : IMailService
    {
        IMailDal _mailDal;
        public MailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public IDataResult<Mail> GetById(int Id)
        {
            return new SuccessDataResult<Mail>(_mailDal.Get(m => m.Id == Id), Messages.MailGeted);
        }

        public IDataResult<List<Mail>> GetAll()
        {
            return new SuccessDataResult<List<Mail>>(_mailDal.GetAll(), Messages.MailListed);
        }

        public IResult Add(Mail mail)
        {
            _mailDal.Add(mail);
            return new Result(true, Messages.MailAdded);
        }

        public IResult Update(Mail mail)
        {
            _mailDal.Update(mail);
            return new Result(true, Messages.MailUpdated);
        }

        public IResult Delete(Mail mail)
        {
            _mailDal.Delete(mail);
            return new Result(true, Messages.MailDeleted);
        }

        public IDataResult<List<Mail>> GetByAliciMail(string aliciMail)
        {
            return new SuccessDataResult<List<Mail>>(_mailDal.GetAll(m => m.AliciMail == aliciMail), Messages.MailListed);
        }

        public IDataResult<List<Mail>> GetByGonderenMail(string gonderenMail)
        {
            return new SuccessDataResult<List<Mail>>(_mailDal.GetAll(m => m.GonderenMail == gonderenMail), Messages.MailListed);
        }

    }
}

