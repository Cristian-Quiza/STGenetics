using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class EditarPropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario = new RepositorioPropietario(new Persistencia.AppContexto());
        [BindProperty]
        public Propietario propietario {get;set;}
        public IActionResult OnGet( int idPropietario)
        {
            propietario = repositorioPropietario.GetPropietario(idPropietario);
            if(propietario == null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(){

            propietario = repositorioPropietario.UpdatePropietario(propietario, propietario.Id);
            return RedirectToPage("./ListarPropietario");
        }
    }
}
