namespace PROGRATHONG7.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int LaboratorioId { get; set; }
        public DateTime Fecha { get; set; }
    }
}