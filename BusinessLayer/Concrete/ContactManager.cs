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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(x => x.ContactID == id);
        }

        public List<Contact> GetList(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

        public void TAdd(Contact t)
        {
            _contactDal.TAdd(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.TDelete(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.TUpdate(t);

        }
    }
}
