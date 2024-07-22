using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class UsuarioDTO
    {
         public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; } = null!;

        public string Contrasena { get; set; } = null!;

        
        public int IdEmpleado { get; set; }
        
        public int? IdRol { get; set; }
    }
}
