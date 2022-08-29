using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T :class
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        T GetById(int id);
        List<T> GetList();
    }
}
