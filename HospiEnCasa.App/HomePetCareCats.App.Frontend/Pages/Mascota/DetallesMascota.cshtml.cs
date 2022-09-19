using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend.Pages
{
    public class DetallesMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota  = new RepositorioMascota(new Persistencia.AppContexto());
        
        public Mascota Mascota {get;set;}
        public IActionResult  OnGet(int idMascota)
        {
            Mascota = repositorioMascota.GetMascota(idMascota);
            if(Mascota==null){
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }
    }
}
