using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> AuthorGetBloglistWithCategory(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.AuthorID == id).ToList();
            }
        }

        public List<Blog> AuthorsLatestBlogs(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.AuthorID == id).OrderByDescending(x=>x.BlogID).ToList();
            }
        }
        public List<Blog> LatestBlogsWithCount(int? count)
        {
            using(var c = new Context())
            {
                return count!=null? c.Blogs.Include(x => x.Category).OrderByDescending(x => x.BlogID).Take((int)count).ToList() : c.Blogs.Include(x => x.Category).OrderByDescending(x => x.BlogID).ToList();
            }
        }

        public List<Blog> GetlistWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();


            }

        }
    }
}
