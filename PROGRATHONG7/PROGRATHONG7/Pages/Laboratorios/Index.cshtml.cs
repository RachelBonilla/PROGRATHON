using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROGRATHONG7.Models;
using PROGRATHONG7.Repositorio;
using System.Collections.Generic;

namespace PROGRATHONG7.Pages.Laboratorios
{
    public class IndexModel : PageModel
    {
        public List<Laboratorio> Laboratorios => InMemoryRepository.Laboratorios;

        [BindProperty] public string Nombre { get; set; }
        [BindProperty] public int Capacidad { get; set; }
        [BindProperty] public string Responsable { get; set; }

        public void OnPost()
        {
            InMemoryRepository.Laboratorios.Add(new Laboratorio
            {
                Id = InMemoryRepository.Laboratorios.Count + 1,
                Nombre = Nombre,
                Capacidad = Capacidad,
                Responsable = Responsable
            });
        }
    }
}