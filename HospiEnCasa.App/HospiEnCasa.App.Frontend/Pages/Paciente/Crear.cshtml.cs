using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class CrearModel : PageModel
    {
        private static  IRepositorioPaciente repositorioPaciente  = new RepositorioPaciente(new Persistencia.AppContexto());
        [BindProperty]
        public Paciente nuevoPaciente {get;set;}

        public void OnGet()
        {
            nuevoPaciente = new Paciente();
        }

        public IActionResult OnPost(){

            repositorioPaciente.AddPaciente(nuevoPaciente);
             return RedirectToPage("./Lista");
        }
    }
}
