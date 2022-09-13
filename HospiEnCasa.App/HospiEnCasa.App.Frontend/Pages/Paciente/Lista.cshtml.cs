using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;


namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListaModel : PageModel
    {

        private readonly  IRepositorioPaciente repo  = new RepositorioPaciente(new Persistencia.AppContexto());
        [BindProperty(SupportsGet =true)]
        public IEnumerable <Paciente> ListPacientes {get; set;} 

        public void OnGet()
        {
            this.ListPacientes = repo.GetAllPacientes();
        }
    }
}
