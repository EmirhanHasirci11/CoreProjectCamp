using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> AuthorGetBloglistWithCategory(int id);
        List<Blog> AuthorsLatestBlogs(int id);
        List<Blog> LatestBlogsWithCount(int? count);
        void AuthorBlogStatusToFalse(int id);
        void AuthorBlogStatusToTrue(int id);
    }
}
