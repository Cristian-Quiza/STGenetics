using Microsoft.EntityFrameworkCore;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public class AppContexto : DbContext
    {
        public DbSet<Mascota> Mascotas {get; set;}
        public DbSet<Propietario> Propietarios {get; set;}
        public DbSet<ProfesionalVeterinario> ProfesionalVeterinarios {get; set;}
         protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HomePetCareCats");
                //en azure se pone "(localdb)\MSSQLLocalDB"
            }
        }
    }
}