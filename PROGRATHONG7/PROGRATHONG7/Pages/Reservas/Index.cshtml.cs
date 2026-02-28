using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Usuario { get; set; }

    [BindProperty]
    public string Laboratorio { get; set; }

    [BindProperty]
    public string Fecha { get; set; }

    [BindProperty]
    public string Hora { get; set; }

    public static List<Reserva> ListaReservas { get; set; } = new List<Reserva>();

    public List<Reserva> ListaReservasInstancia { get; set; }

    public void OnGet()
    {
        ListaReservasInstancia = ListaReservas;
    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrWhiteSpace(Usuario) &&
            !string.IsNullOrWhiteSpace(Laboratorio) &&
            !string.IsNullOrWhiteSpace(Fecha) &&
            !string.IsNullOrWhiteSpace(Hora))
        {
            ListaReservas.Add(new Reserva
            {
                Usuario = Usuario,
                Laboratorio = Laboratorio,
                Fecha = Fecha,
                Hora = Hora
            });
        }
        Usuario = "";
        Laboratorio = "";
        Fecha = "";
        Hora = "";

        ListaReservasInstancia = ListaReservas;

        return Page();
    }
}

public class Reserva
{
    public string Usuario { get; set; }
    public string Laboratorio { get; set; }
    public string Fecha { get; set; }
    public string Hora { get; set; }
}