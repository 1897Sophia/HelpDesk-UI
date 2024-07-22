using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class EstadoDTO
    {
        public int IdEstado { get; set; }

        public int IdTicket{ get; set; }


        public string Estado { get; set; } = null!;
    }
}
