﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.GetList();
        }

        public void TAdd(Admin t)
        {
            _adminDal.TAdd(t);
        }

        public void TDelete(Admin t)
        {
            _adminDal.TDelete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDal.TUpdate(t);
        }
    }
}
