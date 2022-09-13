using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarPacienteModel : PageModel
    {
        private static  IRepositorioPaciente repositorioPaciente  = new RepositorioPaciente(new Persistencia.AppContexto());
        [BindProperty] 

        public Paciente paciente {get;set;}
        public IActionResult OnGet(int idPaciente)
        {
            paciente = repositorioPaciente.GetPaciente(idPaciente);
            if(paciente == null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost(){

            paciente = repositorioPaciente.UpdatePaciente(paciente, paciente.Id);
            return RedirectToPage("./Lista");
        }
    }
}
