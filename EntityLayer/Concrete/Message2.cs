using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message2
    {
        [Key]
        public int MessageID { get; set; }
        public int? Sender { get; set; }
        public int? Receiver { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public Author SenderUser { get; set; }
        public Author ReceiverUser { get; set; }
        public int? RepliedTo { get; set; }
        public bool IsDrafted { get; set; }
        public bool IsImportant { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeletedConfirm { get; set; }
        public bool DeletedBySender { get; set; }
        public bool DeletedBySenderConfirm { get; set; }
    }
}
