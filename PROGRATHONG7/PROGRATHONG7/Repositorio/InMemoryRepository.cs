using PROGRATHONG7.Models;

namespace PROGRATHONG7.Repositorio
{
    public class InMemoryRepository

    {
        public static List<Laboratorio> Laboratorios = new();
        public static List<Usuario> Usuarios = new();
        public static List<Reserva> Reservas = new();
    }
}
