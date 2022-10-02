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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(x => x.MessageID == id);
        }

        public List<Message> GetInboxMessageByAuthor(string ReceiverAuthorMail, int? count)
        {
            return count == null ? _messageDal.GetInboxMessageByAuthor(ReceiverAuthorMail, count) : _messageDal.GetInboxMessageByAuthor(ReceiverAuthorMail, count);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetList();
        }

        public void TAdd(Message t)
        {
            _messageDal.TAdd(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.TDelete(t);
        }

        public void TUpdate(Message t)
        {
            _messageDal.TUpdate(t);
        }
    }
}
