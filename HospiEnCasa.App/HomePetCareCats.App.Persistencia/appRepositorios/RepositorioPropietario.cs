using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        /// <summary>
        /// Referencia al contexto de Propietario
        /// </summary>

        private readonly AppContexto _AppContexto;

        /// <summary>
        /// Metodo Constructor Utilizas
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="AppContexto"></param>//
        ///
        public RepositorioPropietario()
        {
        }

        public RepositorioPropietario(AppContexto AppContexto)
        {
            _AppContexto = AppContexto;
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _AppContexto.Propietarios;
        }
        Propietario IRepositorioPropietario.AddPropietario(Propietario prmPropietario)
        {
            var propietarioAdicionado = _AppContexto.Propietarios.Add(prmPropietario);
            _AppContexto.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario prmPropietario, int idPropietario_original)
        {
            var propietarioEncontrado = _AppContexto.Propietarios.FirstOrDefault(p => p.Id == idPropietario_original);
            if (propietarioEncontrado != null){
                propietarioEncontrado.Nombre = prmPropietario.Nombre;
                propietarioEncontrado.Apellido = prmPropietario.Apellido;
                propietarioEncontrado.Genero = prmPropietario.Genero;
                propietarioEncontrado.Edad = prmPropietario.Edad;
                propietarioEncontrado.NumeroTelefono = prmPropietario.NumeroTelefono;
                propietarioEncontrado.Ciudad = prmPropietario.Ciudad;
                propietarioEncontrado.Direccion = prmPropietario.Direccion;
                propietarioEncontrado.Email = prmPropietario.Email;
                _AppContexto.SaveChanges();
            }
            return propietarioEncontrado;
        }
        Propietario IRepositorioPropietario.GetPropietario(int idPropietario)
        {
            return _AppContexto.Propietarios.FirstOrDefault(p => p.Id == idPropietario);
        }

        void IRepositorioPropietario.DeletePropietario(int idPropietario)
        {
            var PropietarioEncontrada = _AppContexto.Propietarios.FirstOrDefault(m => m.Id == idPropietario);
            if (PropietarioEncontrada == null)
                return;
            _AppContexto.Propietarios.Remove(PropietarioEncontrada);
            _AppContexto.SaveChanges();
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetFiltroPropietarios(string filtro)
        {
            IEnumerable<Propietario> listPropietarios = _AppContexto.Propietarios; // Obtiene todos las Propietarios
            if (listPropietarios != null)  //Si se tienen Propietarios
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    listPropietarios = listPropietarios.Where(p => p.Nombre.Contains(filtro)); 
                }
            }
            return listPropietarios;
        }
    }
}