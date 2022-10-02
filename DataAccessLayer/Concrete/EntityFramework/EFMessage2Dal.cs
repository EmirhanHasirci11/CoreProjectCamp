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
    public class EFMessage2Dal : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetInboxMessageByAuthor(int ReceiverAuthorId, int? count, bool? status)
        {

            using (Context c = new Context())
            {
                if (status == null)
                {

                    return count != null ? c.Message2s.Include(y => y.SenderUser)
                        .Where(x => (x.Receiver == ReceiverAuthorId) &&x.IsDrafted==false &&(x.IsDeleted == false && x.IsDeletedConfirm == false))
                        .OrderByDescending(x => x.MessageDate)
                        .Take((int)count).ToList()
                        : c.Message2s.Include(y => y.SenderUser)
                        .Where(x => (x.Receiver == ReceiverAuthorId) &&x.IsDrafted==false && (x.IsDeleted == false && x.IsDeletedConfirm == false))
                        .OrderByDescending(x => x.MessageDate)
                        .ToList();
                }
                else if (status == true)
                {
                    return count != null ? c.Message2s.Include(y => y.SenderUser)
                        .Where(x => (x.Receiver == ReceiverAuthorId && x.MessageStatus == true) && x.IsDrafted == false && (x.IsDeleted == false && x.IsDeletedConfirm == false))
                        .OrderByDescending(x => x.MessageDate)
                        .Take((int)count)
                        .ToList()
                        : c.Message2s.Include(y => y.SenderUser)
                        .Where(x => (x.Receiver == ReceiverAuthorId && x.MessageStatus == true) && x.IsDrafted == false && (x.IsDeleted == false && x.IsDeletedConfirm == false))
                        .OrderByDescending(x => x.MessageDate)
                        .ToList();
                }
                else
                {
                    return count != null ? c.Message2s.Include(y => y.SenderUser)
                        .Where(x => (x.Receiver == ReceiverAuthorId && x.MessageStatus == false) && x.IsDrafted == false && (x.IsDeleted == false && x.IsDeletedConfirm == false))
                        .OrderByDescending(x => x.MessageDate)
                        .Take((int)count)
                        .ToList()
                        : c.Message2s.Include(y => y.SenderUser)
                        .Where(x => (x.Receiver == ReceiverAuthorId && x.MessageStatus == false) && x.IsDrafted == false && (x.IsDeleted == false && x.IsDeletedConfirm == false))
                        .OrderByDescending(x => x.MessageDate)
                        .ToList();
                }
            };
        }
        public Message2 GetByIdWAuthor(int id)
        {
            using (Context c = new Context())
            {
                return c.Message2s.Include(x => x.SenderUser).Where(y => y.MessageID == id).FirstOrDefault();
            }
        }
        public Message2 GetByIdWReceiverAuthor(int id)
        {
            using (Context c = new Context())
            {
                return c.Message2s.Include(x => x.ReceiverUser)
                    .Where(y => y.MessageID == id)
                    .FirstOrDefault();
            }
        }

        public List<Message2> GetSendboxMessageByAuthor(int SenderAuthorId, int? count)
        {
            using (Context c = new Context())
            {
                return count != null ? c.Message2s.Include(y => y.ReceiverUser)
                    .Where(x => (x.Sender == SenderAuthorId) &&x.IsDrafted==false &&(x.DeletedBySender == false && x.DeletedBySenderConfirm == false)).OrderByDescending(x => x.MessageDate)
                    .Take((int)count)
                    .ToList()
                    : c.Message2s.Include(y => y.ReceiverUser)
                    .Where(x => (x.Sender == SenderAuthorId) && (x.DeletedBySender == false && x.DeletedBySenderConfirm == false)).OrderByDescending(x => x.MessageDate)
                    .ToList();
            }
        }

        public List<Message2> GetImportantBoxByAuthorForReceiver(int AuthorID)
        {
            using (Context c = new Context())
            {
                return c.Message2s.Include(x => x.SenderUser)
                    .Where(x => (x.Receiver == AuthorID ) &&( x.IsImportant == true&& x.IsDrafted == false && (x.IsDeleted==false&&x.IsDeletedConfirm==false)))
                    .OrderByDescending(x => x.MessageDate)
                    .ToList();
            }
        }
        public List<Message2> GetImportantBoxByAuthorForSender(int AuthorID)
        {
            using (Context c = new Context())
            {
                return c.Message2s.Include(x => x.ReceiverUser)
                    .Where(x => (  x.Sender == AuthorID) && (x.IsImportant == true && x.IsDrafted == false && (x.DeletedBySender == false && x.DeletedBySenderConfirm== false)))
                    .OrderByDescending(x => x.MessageDate)
                    .ToList();
            }
        }

        public List<Message2> GetDraftBoxByAuthor(int AuthorID)
        {
            using (Context c = new Context())
            {
                return c.Message2s.Include(y => y.ReceiverUser)
                    .Where(x => (x.Sender == AuthorID && x.IsDrafted == true) && (x.DeletedBySender == false && x.DeletedBySenderConfirm== false))
                    .OrderByDescending(x => x.MessageDate)
                    .ToList();
            }
        }

        public List<Message2> GetTrashBoxByAuthorForReceiver(int AuthorID)
        {
            using (Context c = new Context())
            {
                return c.Message2s
                    .Include(x => x.SenderUser)
                    .Where(x => (x.Receiver == AuthorID && ((x.IsDeleted == true && x.IsDeletedConfirm == false))))
                    .OrderByDescending(x => x.MessageDate)
                    .ToList();
            }
        }
        public List<Message2> GetTrashBoxByAuthorForSender(int AuthorID)
        {
            using (Context c = new Context())
            {
                return c.Message2s
                    .Include(x => x.ReceiverUser)
                    .Where(x => (x.Sender == AuthorID && ((x.DeletedBySender == true && x.DeletedBySenderConfirm == false))))
                    .OrderByDescending(x => x.MessageDate)
                    .ToList();
            }
        }

    }
}
