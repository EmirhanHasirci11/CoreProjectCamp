using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public void AddComment(Comment C, int blogid)
        {
            using (var c = new Context())
            {
                C.BlogID = blogid;
                C.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                c.Comments.Add(C);
            };
               
        }
    }
}
