using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Persistencia;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Frontend
{
    public class CrearPropietarioModel : PageModel
    {
        private readonly  IRepositorioPropietario repositorioPropietario  = new RepositorioPropietario(new Persistencia.AppContexto());
        [BindProperty]
        public Propietario nuevoPropietario {get;set;}

        public void OnGet()
        {
            nuevoPropietario = new Propietario();
        }

        public IActionResult OnPost(){

            repositorioPropietario.AddPropietario(nuevoPropietario);
             return RedirectToPage("./ListarPropietario");
        }
    }
}
