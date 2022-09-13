using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContexto : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes { get; set; }
          protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
              optionsBuilder
              .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HomePetCareData");
              // en azure se pone "(localdb)\MSSQLLocalDB"
            }
        }
    }
}