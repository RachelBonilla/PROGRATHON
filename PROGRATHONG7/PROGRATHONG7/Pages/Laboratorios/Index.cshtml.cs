using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROGRATHONG7.Models;
using System.Collections.Generic;

namespace PROGRATHONG7.Pages.Laboratorios
{
    public class IndexModel : PageModel
    {
        [BindProperty] public string Nombre { get; set; }
        [BindProperty] public int Capacidad { get; set; }
        [BindProperty] public string Responsable { get; set; }

        public static List<Laboratorio> ListaLaboratorios { get; set; } = new List<Laboratorio>();

        public List<Laboratorio> LaboratoriosInstancia { get; set; }

        public void OnGet()
        {
            LaboratoriosInstancia = ListaLaboratorios;
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrWhiteSpace(Nombre) &&
                Capacidad > 0 &&
                !string.IsNullOrWhiteSpace(Responsable))
            {
                ListaLaboratorios.Add(new Laboratorio
                {
                    Id = ListaLaboratorios.Count + 1,
                    Nombre = Nombre,
                    Capacidad = Capacidad,
                    Responsable = Responsable
                });
            }

            Nombre = "";
            Capacidad = 0;
            Responsable = "";

            LaboratoriosInstancia = ListaLaboratorios;

            return Page();
        }
    }
}