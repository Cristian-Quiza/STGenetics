using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario AddPropietario(Propietario prmPropietario);
        Propietario UpdatePropietario(Propietario prmPropietario, int idPropietario_original);
        Propietario GetPropietario(int idPropietario);
        IEnumerable<Propietario> GetFiltroPropietarios(string filtro);
        void DeletePropietario (int idPropietario);
    }
}