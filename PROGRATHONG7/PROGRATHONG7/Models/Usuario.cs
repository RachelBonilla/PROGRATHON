namespace PROGRATHONG7.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Estudiante / Profesor
        public string Correo { get; set; }
    }
}
