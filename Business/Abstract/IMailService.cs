using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMailService
    {
        IDataResult<Mail> GetById(int Id);
        IDataResult<List<Mail>> GetAll();
        IResult Add(Mail mail);
        IResult Update(Mail mail);
        IResult Delete(Mail mail);
        IDataResult<List<Mail>> GetByAliciMail(string aliciMail);
        IDataResult<List<Mail>> GetByGonderenMail(string gonderenMail);
    }
}
