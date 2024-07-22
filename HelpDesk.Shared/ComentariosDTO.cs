using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class ComentariosDTO
    {
        public int IdComentario { get; set; }

        public string DetalleComentario { get; set; } = null!;

        public DateTime FechaHora { get; set; }


        public int IdEmpleado { get; set; }


        public int? IdTicket { get; set; }

        public int? IdComentarioPadre { get; set; }

        public ComentariosDTO? comentario { get; set; }
        
        public List<ComentarioConRespuestasDTO>? respuestas { get; set; } = new List<ComentarioConRespuestasDTO>();

        public string? NombreEmpleado { get; set; }
        public string? ApellidosEmpleado { get; set; }
        public class ComentarioNodo
        {
            public ComentariosDTO Comentario { get; set; } = null!;
            public List<ComentarioNodo> Respuestas { get; set; } = new List<ComentarioNodo>();
        }
    }
}
