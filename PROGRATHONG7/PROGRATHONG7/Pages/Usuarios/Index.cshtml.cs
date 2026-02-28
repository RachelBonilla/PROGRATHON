using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROGRATHONG7.Models;

namespace PROGRATHONG7.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Usuario NuevoUsuario { get; set; } = new Usuario();

        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public List<Usuario> ListaUsuarios { get; set; }

        public void OnGet()
        {
            ListaUsuarios = Usuarios;
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrWhiteSpace(NuevoUsuario.Nombre) &&
                !string.IsNullOrWhiteSpace(NuevoUsuario.Tipo) &&
                !string.IsNullOrWhiteSpace(NuevoUsuario.Correo))
            {
                Usuarios.Add(new Usuario
                {
                    Nombre = NuevoUsuario.Nombre,
                    Tipo = NuevoUsuario.Tipo,
                    Correo = NuevoUsuario.Correo
                });
            }

            NuevoUsuario = new Usuario();
            ListaUsuarios = Usuarios;

            return Page();
        }
    }
}