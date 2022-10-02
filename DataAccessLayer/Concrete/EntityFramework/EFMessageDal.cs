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
    public class EFMessageDal : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetInboxMessageByAuthor(string ReceiverAuthorMail, int? count)
        {

            using (Context c = new Context())
            {
                return count != null ? c.Messages.Where(x => x.Receiver == ReceiverAuthorMail).OrderByDescending(x => x.MessageDate).Take((int)count).ToList() : c.Messages.Where(x => x.Receiver == ReceiverAuthorMail).OrderByDescending(x => x.MessageDate).ToList();
            };
        }
        
    }
}
