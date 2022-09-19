using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class EditarVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContexto());
        [BindProperty]

        public ProfesionalVeterinario veterinario {get;set;}
        public IActionResult OnGet( int idVeterinario)
        {
            veterinario = repositorioVeterinario.GetVeterinario(idVeterinario);
            if(veterinario == null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(){

            veterinario = repositorioVeterinario.UpdateVeterinario(veterinario, veterinario.Id);
            return RedirectToPage("./ListarVeterinario");
        }
    }
}
