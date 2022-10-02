using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Author.Models.Message
{
    public class MessageReply
    {
        public DateTime MessageDate{ get; set; }
        public string MessageDetails{ get; set; }
        public string MessageSubject{ get; set; }
        public string SenderNameSurname{ get; set; }
        public string SenderMail{ get; set; }
        public string SenderImage{ get; set; }

    }
}
