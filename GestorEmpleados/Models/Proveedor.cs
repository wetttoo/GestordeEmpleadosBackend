namespace MiWebAPI.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Telefono { get; set; }
        public int Edad { get; set; }
        public string? Empresa { get; set; }
    }
}
