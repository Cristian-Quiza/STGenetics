using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Persistencia;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Frontend.Pages
{
    public class CrearMascotaModel : PageModel
    {
        private static  IRepositorioMascota repositorioMascota  = new RepositorioMascota(new Persistencia.AppContexto());
        [BindProperty]
        public Mascota nuevoMascota {get;set;}

        public void OnGet()
        {
            nuevoMascota = new Mascota();
        }

        public IActionResult OnPost(){

            repositorioMascota.AddMascota(nuevoMascota);
             return RedirectToPage("./ListarMascota");
        }
    }
}
