using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class EliminarVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContexto());
        [BindProperty]
        public ProfesionalVeterinario veterinario {get;set;}
        public IActionResult OnGet(int? idVeterinario)
        {
            if (idVeterinario.HasValue)
            {
                veterinario = repositorioVeterinario.GetVeterinario(idVeterinario.Value);
            }
            
            if (veterinario == null)
            {
                return RedirectToPage("./Notfound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
                
            if (veterinario.Id>0)
            {   
                repositorioVeterinario.DeleteVeterinario(veterinario.Id);
                return RedirectToPage("./ListarVeterinario");
            }
            
            return Page();
        }
    }
}
