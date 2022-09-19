using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Persistencia;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Frontend
{
    public class CrearVeterinarioModel : PageModel
    {
        private readonly  IRepositorioVeterinario repositorioVeterinario  = new RepositorioVeterinario(new Persistencia.AppContexto());
        [BindProperty]
        public ProfesionalVeterinario nuevoVeterinario {get;set;}

        public void OnGet()
        {
            nuevoVeterinario = new ProfesionalVeterinario();
        }

        public IActionResult OnPost(){

            repositorioVeterinario.AddVeterinario(nuevoVeterinario);
             return RedirectToPage("./ListarVeterinario");
        }
    }
}
