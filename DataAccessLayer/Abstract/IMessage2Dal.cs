using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2Dal : IGenericDal<Message2>
    {
        List<Message2> GetInboxMessageByAuthor(int ReceiverAuthorId, int? count, bool? status);
        List<Message2> GetSendboxMessageByAuthor(int SenderAuthorId, int? count);
        List<Message2> GetImportantBoxByAuthorForSender(int AuthorID);

        List<Message2> GetImportantBoxByAuthorForReceiver(int AuthorID);
        List<Message2> GetDraftBoxByAuthor(int AuthorID);
        List<Message2> GetTrashBoxByAuthorForReceiver(int AuthorID);
        List<Message2> GetTrashBoxByAuthorForSender(int AuthorID);
        Message2 GetByIdWReceiverAuthor(int id);
        Message2 GetByIdWAuthor(int id);
    }
}
