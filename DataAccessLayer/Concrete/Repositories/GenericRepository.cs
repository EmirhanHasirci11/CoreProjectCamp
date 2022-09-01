using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public T GetById(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).FirstOrDefault();
        }

        

        public List<T> GetList(Expression<Func<T, bool>> filter=null)
        {
            using var c = new Context();
            return filter == null ? c.Set<T>().ToList() : c.Set<T>().Where(filter).ToList();
        }

        public void TAdd(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void TDelete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public void TUpdate(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
