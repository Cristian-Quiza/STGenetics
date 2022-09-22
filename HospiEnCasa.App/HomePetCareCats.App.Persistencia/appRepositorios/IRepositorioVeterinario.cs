using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<ProfesionalVeterinario> GetAllVeterinarios();
        ProfesionalVeterinario AddVeterinario(ProfesionalVeterinario prmVeterinario);
        ProfesionalVeterinario UpdateVeterinario(ProfesionalVeterinario prmVeterinario, int idVeterinario_original);
        ProfesionalVeterinario GetVeterinario(int idVeterinario);
        IEnumerable<ProfesionalVeterinario> GetFiltroVeterinarios(string filtro);
        void DeleteVeterinario (int idVeterinario);
    }
}