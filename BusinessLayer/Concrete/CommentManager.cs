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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment C, int blogid)
        {
            _commentDal.AddComment(C, blogid);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(x=>x.BlogID==id);
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetList(x=>x.BlogID==id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }

        public void TAdd(Comment t)
        {
            t.CommentStatus = true;
            t.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _commentDal.TAdd(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.TDelete(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.TUpdate(t);
        }
    }
}
