using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class EliminarMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContexto());
        [BindProperty]
        public Mascota mascota {get;set;}
        public IActionResult OnGet(int? idMascota)
        {
            if (idMascota.HasValue)
            {
                mascota = repositorioMascota.GetMascota(idMascota.Value);
            }
            
            if (mascota == null)
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
                
            if (mascota.Id>0)
            {   
                repositorioMascota.DeleteMascota(mascota.Id);
                 return RedirectToPage("./ListarMascota");
            }
            
            return Page();
        }
    }
}
