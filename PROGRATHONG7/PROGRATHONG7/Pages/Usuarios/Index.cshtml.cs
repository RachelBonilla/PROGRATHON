using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROGRATHONG7.Models;
using PROGRATHONG7.Repositorio;
using System.Collections.Generic;

namespace PROGRATHONG7.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        public List<Usuario> Usuarios { get; set; } = new();

        public void OnGet()
        {
            Usuarios = InMemoryRepository.Usuarios;
        }

        public IActionResult OnPost(string Nombre, string Tipo, string Correo)
        {
            InMemoryRepository.Usuarios.Add(new Usuario
            {
                Nombre = Nombre,
                Tipo = Tipo,
                Correo = Correo
            });

            return RedirectToPage();
        }
    }
}