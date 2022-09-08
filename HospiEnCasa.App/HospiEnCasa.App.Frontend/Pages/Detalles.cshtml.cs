using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class DetallesModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente {get;set;}
        public DetallesModel (IRepositorioPaciente repositorioPaciente){
            this.repositorioPaciente = repositorioPaciente;
        }
        public IActionResult OnGet(int idPaciente)
        {
            Paciente = repositorioPaciente.GetPaciente(idPaciente);
            if(Paciente==null){
                return RedirectToPage("./NotFound");
            }
            else 
            return Page();
        }
    }
}
