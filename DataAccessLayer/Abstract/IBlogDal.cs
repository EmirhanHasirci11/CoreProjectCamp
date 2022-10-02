﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetlistWithCategory();
        List<Blog> AuthorGetBloglistWithCategory(int id);
        List<Blog> AuthorsLatestBlogs(int id);
        List<Blog> LatestBlogsWithCount(int? count);
    }
}
