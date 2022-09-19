using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Persistencia;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Frontend.Pages
{
    public class EditarMascotaModel : PageModel
    {
        private static  IRepositorioMascota repositorioMascota  = new RepositorioMascota(new Persistencia.AppContexto());
        [BindProperty] 

        public Mascota mascota {get;set;}
        public IActionResult OnGet(int idMascota)
        {
            mascota = repositorioMascota.GetMascota(idMascota);
            if(mascota == null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(){

            mascota = repositorioMascota.UpdateMascota(mascota, mascota.Id);
            return RedirectToPage("./ListarMascota");
        }
    }
}
