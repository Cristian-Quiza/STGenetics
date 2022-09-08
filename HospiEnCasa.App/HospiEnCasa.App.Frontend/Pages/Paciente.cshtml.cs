using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class PacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public IEnumerable <Paciente> ListPacientes {get; set;} 

        public PacienteModel (IRepositorioPaciente repositorioPaciente){
            this.repositorioPaciente = repositorioPaciente;
        }
        public void OnGet()
        {
            ListPacientes = repositorioPaciente.GetAllPacientes();
        }
    }
}
