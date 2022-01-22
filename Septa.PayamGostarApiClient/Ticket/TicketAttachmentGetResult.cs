using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septa.PayamGostarApiClient.Ticket
{
    public class TicketAttachmentGetResult
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long FileSize { get; set; }
        public int MessageTypeIndex { get; set; }
    }
}
