using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota prmMascota);
        Mascota UpdateMascota(Mascota prmMascota, int idMascota_original);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetFiltroMascotas(string filtro);
        void DeleteMascota (int idMascota);
    }
}