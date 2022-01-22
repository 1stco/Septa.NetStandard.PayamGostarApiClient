using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketReplyGetResult
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Content { set; get; }
        public string SenderName { set; get; }
        public string FromSrc { set; get; }
        public DateTime Date { set; get; }

        /// <summary>
        /// Gp_MessageType.SentMessage (1), Gp_MessageType.ReceivedMessage (3)
        /// </summary>
        public string MessageType { set; get; }
        public TimeSpan? Time { set; get; }

        public string IdentityId { get; set; }

        public List<TicketAttachmentGetResult> Files { set; get; }
    }
}
