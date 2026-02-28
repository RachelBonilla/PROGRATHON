using PROGRATHONG7.Models;

namespace PROGRATHONG7.Repositorio
{
    public class InMemoryRepository
    {

        private readonly List<Usuario> _usuarios = new();
        private readonly List<Laboratorio> _laboratorios = new();
        private readonly List<Reserva> _reservas = new();

        private int _usuarioSeq = 1;
        private int _laboratorioSeq = 1;
        private int _reservaSeq = 1;

        //Ejemplos
        public InMemoryRepository()
        {
            _laboratorios.Add(new Laboratorio { Id = _laboratorioSeq++, Nombre = "Lab 1", Capacidad = 30, Responsable = "Ana" });
            _laboratorios.Add(new Laboratorio { Id = _laboratorioSeq++, Nombre = "Lab 2", Capacidad = 25, Responsable = "Luis" });

            _usuarios.Add(new Usuario { Id = _usuarioSeq++, Nombre = "Carlos", Tipo = "Estudiante", Correo = "carlos@uni.com" });
            _usuarios.Add(new Usuario { Id = _usuarioSeq++, Nombre = "María", Tipo = "Profesor", Correo = "maria@uni.com" });
        }
        // USUARIOS
        public IEnumerable<Usuario> GetUsuarios() => _usuarios;

        public void AddUsuario(Usuario u)
        {
            u.Id = _usuarioSeq++;
            _usuarios.Add(u);
        }

        // LABORATORIOS

        public IEnumerable<Laboratorio> GetLaboratorios() => _laboratorios;

        public void AddLaboratorio(Laboratorio l)
        {
            l.Id = _laboratorioSeq++;
            _laboratorios.Add(l);
        }

        // RESERVAS

        public IEnumerable<Reserva> GetReservas() => _reservas;

        public void AddReserva(Reserva r)
        {
            r.Id = _reservaSeq++;
            _reservas.Add(r);
        }

        public void CancelarReserva(int id)
        {
            var reserva = _reservas.FirstOrDefault(r => r.Id == id);
            if (reserva != null)
                _reservas.Remove(reserva);
        }
    }
}