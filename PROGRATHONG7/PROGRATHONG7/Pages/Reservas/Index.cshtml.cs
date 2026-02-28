using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PROGRATHONG7.Models;
using PROGRATHONG7.Repositorio;
using System.Collections.Generic;
using System;

namespace PROGRATHONG7.Pages.Reservas
{
    public class IndexModel : PageModel
    {
        public List<Reserva> Reservas => InMemoryRepository.Reservas;

        [BindProperty] public int UsuarioId { get; set; }
        [BindProperty] public int LaboratorioId { get; set; }
        [BindProperty] public DateTime Fecha { get; set; }

        public void OnPost()
        {
            InMemoryRepository.Reservas.Add(new Reserva
            {
                Id = InMemoryRepository.Reservas.Count + 1,
                UsuarioId = UsuarioId,
                LaboratorioId = LaboratorioId,
                Fecha = Fecha
            });
        }
    }
}