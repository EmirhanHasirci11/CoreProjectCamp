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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> AuthorGetBloglistWithCategory(int id)
        {
            return _blogDal.AuthorGetBloglistWithCategory(id);
        }

        public List<Blog> AuthorsLatestBlogs(int id)
        {
            return _blogDal.AuthorsLatestBlogs(id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetlistWithCategory();
        }
       
        public Blog GetById(int id)
        {
            return _blogDal.GetById(x=>x.BlogID==id);

        }

        public List<Blog> GetList()
        {
            return _blogDal.GetList();
        }

        public List<Blog> GetList(int id)
        {
            return _blogDal.GetList(x => x.BlogID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.TAdd(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.TDelete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.TUpdate(t);
        }
    }
}
