using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class TicketsAsignadoDTO
    {
        public int IdTicketAsignado { get; set; }
        public int IdEmpleado { get; set; }
        public int IdTicket { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
