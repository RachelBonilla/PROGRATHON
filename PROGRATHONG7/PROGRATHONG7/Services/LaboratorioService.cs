using PROGRATHONG7.Models;
using PrograthonReservas.Models;
using System.Collections.Generic;

namespace PrograthonReservas.Services
{
    public class LaboratorioService
    {
        public List<Laboratorio> ObtenerLaboratorios()
        {
            return new List<Laboratorio>
            {
                new Laboratorio { Id = 1, Nombre = "Lab Redes", Capacidad = 25 },
                new Laboratorio { Id = 2, Nombre = "Lab Software", Capacidad = 30 }
            };
        }
    }
}