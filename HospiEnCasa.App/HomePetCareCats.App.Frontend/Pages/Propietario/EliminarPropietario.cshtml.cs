using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class EliminarPropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario = new RepositorioPropietario(new Persistencia.AppContexto());
        [BindProperty]
        public Propietario propietario {get;set;}
        public IActionResult OnGet(int? idPropietario)
        {
            if (idPropietario.HasValue)
            {
                propietario = repositorioPropietario.GetPropietario(idPropietario.Value);
            }
            
            if (propietario == null)
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
                
            if (propietario.Id>0)
            {   
                repositorioPropietario.DeletePropietario(propietario.Id);
                return RedirectToPage("./ListarPropietario");
            }
            
            return Page();
        }
    }
}
