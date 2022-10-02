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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void ConfirmDeleteForReceiver(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.IsDeleted = true;
            message.IsDeletedConfirm = true;
            _message2Dal.TUpdate(message);
        }

        public void ConfirmDeleteForSender(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.DeletedBySender = true;
            message.DeletedBySenderConfirm = true;
            _message2Dal.TUpdate(message);
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetById(x => x.MessageID == id);

        }

        public Message2 GetByIdWAuthor(int id)
        {
            return _message2Dal.GetByIdWAuthor(id);
        }

        public Message2 GetByIdWReceiverAuthor(int id)
        {
            return _message2Dal.GetByIdWReceiverAuthor(id);
        }

        public List<Message2> GetDraftBoxByAuthor(int AuthorID)
        {
            return _message2Dal.GetDraftBoxByAuthor(AuthorID);
        }

        public List<Message2> GetImportantBoxByAuthorForReceiver(int AuthorID)
        {
            return _message2Dal.GetImportantBoxByAuthorForReceiver(AuthorID);
        }

        public List<Message2> GetImportantBoxByAuthorForSender(int AuthorID)
        {
            return _message2Dal.GetImportantBoxByAuthorForSender(AuthorID);
        }

       

        public List<Message2> GetInboxMessageByAuthor(int ReceiverAuthorId, int? count, bool? status)
        {
            if (status == null)
            {

                return _message2Dal.GetInboxMessageByAuthor(ReceiverAuthorId, count, null);
            }
            else
            {
                return _message2Dal.GetInboxMessageByAuthor(ReceiverAuthorId, count, status);
            }
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetList();
        }

        public List<Message2> GetSendboxMessageByAuthor(int SenderAuthorId, int? count)
        {
            return _message2Dal.GetSendboxMessageByAuthor(SenderAuthorId, count);
        }

        public List<Message2> GetTrashBoxByAuthorForReceiver(int AuthorID)
        {
            return _message2Dal.GetTrashBoxByAuthorForReceiver(AuthorID);
        }

        public List<Message2> GetTrashBoxByAuthorForSender(int AuthorID)
        {
            return _message2Dal.GetTrashBoxByAuthorForSender(AuthorID);
        }

        public void RecoverFromTrashboxReceiver(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.IsDeleted = false;
            _message2Dal.TUpdate(message);
        }

        public void RecoverFromTrashboxSender(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.DeletedBySender = false;
            _message2Dal.TUpdate(message);
        }

        public void RemoveImportant(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.IsImportant = false;
            _message2Dal.TUpdate(message);
        }

        public void SendToTrashReceiver(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.IsDeleted =true;
            _message2Dal.TUpdate(message);
        }

        public void SendToTrashSender(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.IsDrafted = false;
            message.DeletedBySender = true;
            _message2Dal.TUpdate(message);
        }

        public void SetAsImportant(int id)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.IsImportant = true;
            _message2Dal.TUpdate(message);
        }

        public void SetMessageStatus(int id, bool status)
        {
            var message = _message2Dal.GetById(x => x.MessageID == id);
            message.MessageStatus = status;
            _message2Dal.TUpdate(message);
        }

        public void TAdd(Message2 t)
        {
            _message2Dal.TAdd(t);
        }

        public void TDelete(Message2 t)
        {
            _message2Dal.TDelete(t);
        }

        public void TUpdate(Message2 t)
        {
            _message2Dal.TUpdate(t);
        }
    }
}
