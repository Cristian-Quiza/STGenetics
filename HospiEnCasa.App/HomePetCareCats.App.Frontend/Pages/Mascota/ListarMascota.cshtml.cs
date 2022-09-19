using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend.Pages
{
    public class ListarMascotaModel : PageModel
    {
        private readonly  IRepositorioMascota repo  = new RepositorioMascota(new Persistencia.AppContexto());
        [BindProperty(SupportsGet =true)]
        public IEnumerable <Mascota> ListMascotas {get; set;} 

        public void OnGet()
        {
            this.ListMascotas = repo.GetAllMascotas();
        }
    }
}
