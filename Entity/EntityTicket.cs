using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntityTicket
    {
        public int TicketID { get; set; }
        public decimal TicketPrice { get; set; }
        public int TicketQty { get; set; }
        public int BusID { get; set; }
    }
}
