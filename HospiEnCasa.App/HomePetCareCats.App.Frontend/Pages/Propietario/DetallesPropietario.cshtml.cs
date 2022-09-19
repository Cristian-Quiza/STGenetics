using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class DetallesPropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario  = new RepositorioPropietario(new Persistencia.AppContexto());
        
        public Propietario Propietario {get;set;}
        public IActionResult  OnGet(int idPropietario)
        {
            Propietario = repositorioPropietario.GetPropietario(idPropietario);
            if(Propietario==null){
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }
    }
}
