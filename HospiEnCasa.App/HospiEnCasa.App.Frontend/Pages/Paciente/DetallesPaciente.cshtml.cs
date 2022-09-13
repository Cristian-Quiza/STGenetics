using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class DetallesPacienteModel : PageModel
    {
        private readonly   IRepositorioPaciente repositorioPaciente  = new RepositorioPaciente(new Persistencia.AppContexto());
        
        public Paciente Paciente {get;set;}
        public IActionResult  OnGet(int idPaciente)
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
