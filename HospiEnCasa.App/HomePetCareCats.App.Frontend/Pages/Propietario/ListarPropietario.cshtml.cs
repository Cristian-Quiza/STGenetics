using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class ListarPropietarioModel : PageModel
    {
        private readonly  IRepositorioPropietario repo  = new RepositorioPropietario(new Persistencia.AppContexto());
        [BindProperty(SupportsGet =true)]
        public IEnumerable <Propietario> ListPropietarios {get; set;} 

        public void OnGet()
        {
            this.ListPropietarios = repo.GetAllPropietarios();
        }
    }
}
