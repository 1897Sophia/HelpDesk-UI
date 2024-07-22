using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Shared
{
    public class TicketsDTO
    {
        public int IdTicket { get; set; }
        public string DetalleTicket { get; set; }
        public DateTime? FechaHora { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCategoria { get; set; }
        public int IdEstado { get; set; }
        public int IdSubcategoria { get; set; }
        public byte[]? Image_Ticket { get; set; }
        public byte[]? ImageTicket { get; set; }
        public string? NombreCategoria { get; set; }
        public string? NombreSubcategoria { get; set; }
        public string? NombreEmpleado { get; set; }
        public string? Nombre_Departamento { get; set; }
        public string? ApellidosEmpleado { get; set; }
        public string? Estado { get; set; }

    }
}