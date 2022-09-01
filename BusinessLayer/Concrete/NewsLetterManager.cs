using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {

        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public NewsLetter GetById(int id)
        {
            return _newsLetterDal.GetById(x => x.MailID == id);
        }
        //todo genericservice'den int id alan parametretli listi çıkar
        public List<NewsLetter> GetList(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            return _newsLetterDal.GetList();
            
        }

        public void TAdd(NewsLetter t)
        {
            _newsLetterDal.TAdd(t);
        }

        public void TDelete(NewsLetter t)
        {
            _newsLetterDal.TDelete(t);
        }

        public void TUpdate(NewsLetter t)
        {
            _newsLetterDal.TUpdate(t);
        }
    }
}
