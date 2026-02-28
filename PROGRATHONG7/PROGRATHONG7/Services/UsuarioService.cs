using PROGRATHONG7.Models;
using PrograthonReservas.Models;
using System.Collections.Generic;

namespace PrograthonReservas.Services
{
    public class UsuarioService
    {
        public List<Usuario> ObtenerUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario { Id = 1, Nombre = "Ana", Correo = "ana@ucr.ac.cr" },
                new Usuario { Id = 2, Nombre = "Luis", Correo = "luis@ucr.ac.cr" }
            };
        }
    }
}