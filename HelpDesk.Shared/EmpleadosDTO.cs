namespace HelpDesk.Shared
{
    public class EmpleadosDTO
    {
        public int IdEmpleado { get; set; }
        public int IdRol { get; set; }

        public string? NombreRol { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string CedulaEmpleado { get; set; }
        public string CorreoEmpleado { get; set; }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public string TelefonoEmpleado { get; set; }
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

    }
}
