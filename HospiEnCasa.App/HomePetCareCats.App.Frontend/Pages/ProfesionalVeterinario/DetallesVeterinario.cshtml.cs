using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class DetallesVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario  = new RepositorioVeterinario(new Persistencia.AppContexto());
        
        public ProfesionalVeterinario Veterinario {get;set;}
        public IActionResult  OnGet(int idVeterinario)
        {
            Veterinario = repositorioVeterinario.GetVeterinario(idVeterinario);
            if(Veterinario==null){
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }
    }
}
