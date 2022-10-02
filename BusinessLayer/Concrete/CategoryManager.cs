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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void ChangeStatus(int id, bool status)
        {
            var categoryValue = _categoryDal.GetById(x => x.CategoryID == id);
            categoryValue.CategoryStatus = status;
            _categoryDal.TUpdate(categoryValue);
        }

        public Category GetById(int id)
        {
           return _categoryDal.GetById(x=>x.CategoryID==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public List<Category> GetList(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Category t)
        {
            _categoryDal.TAdd(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.TDelete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.TUpdate(t);
        }
    }
}
