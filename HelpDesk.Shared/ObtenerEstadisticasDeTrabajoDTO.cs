using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class ObtenerEstadisticasDeTrabajoDTO
    {
        public int TicketsCompletados { get; set; }
        public int TicketsAsignados { get; set; }
        public Decimal PorcentajeTrabajo { get; set; }

        public DateTime FechaHora { get; set; }    
    }
}
