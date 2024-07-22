using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class Estado_TicketDTO
    {
        public int IdEstado { get; set; }

        public string NombreEstado { get; set; } = null!;

    }
}
