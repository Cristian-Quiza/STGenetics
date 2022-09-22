using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCareCats.App.Dominio;
using HomePetCareCats.App.Persistencia;

namespace HomePetCareCats.App.Frontend
{
    public class ListarVeterinarioModel : PageModel
    {
        private readonly  IRepositorioVeterinario repo  = new RepositorioVeterinario(new Persistencia.AppContexto());
        [BindProperty(SupportsGet =true)]
        public IEnumerable <ProfesionalVeterinario> ListVeterinarios {get; set;} 
        public string FiltroBusqueda { get; set; }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            this.ListVeterinarios =repo.GetFiltroVeterinarios(filtroBusqueda);
        }
    }
}
