using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HomePetCareCats.App.Dominio;

namespace HomePetCareCats.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        /// <summary>
        /// Referencia al contexto de Veterinario
        /// </summary>

        private readonly AppContexto _AppContexto;

        /// <summary>
        /// Metodo Constructor Utilizas
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="AppContexto"></param>//
        ///
        public RepositorioVeterinario()
        {
        }

        public RepositorioVeterinario(AppContexto AppContexto)
        {
            _AppContexto = AppContexto;
        }

        IEnumerable<ProfesionalVeterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _AppContexto.ProfesionalVeterinarios;
        }
        ProfesionalVeterinario IRepositorioVeterinario.AddVeterinario(ProfesionalVeterinario prmVeterinario)
        {
            var veterinarioAdicionado = _AppContexto.ProfesionalVeterinarios.Add(prmVeterinario);
            _AppContexto.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        ProfesionalVeterinario IRepositorioVeterinario.UpdateVeterinario(ProfesionalVeterinario prmVeterinario, int idVeterinario_original)
        {
            var veterinarioEncontrado = _AppContexto.ProfesionalVeterinarios.FirstOrDefault(m => m.Id == idVeterinario_original);
            if (veterinarioEncontrado != null){
                veterinarioEncontrado.Nombre = prmVeterinario.Nombre;
                veterinarioEncontrado.Apellido = prmVeterinario.Apellido;
                veterinarioEncontrado.Genero = prmVeterinario.Genero;
                veterinarioEncontrado.Edad = prmVeterinario.Edad;
                veterinarioEncontrado.NumeroTelefono = prmVeterinario.NumeroTelefono;
                veterinarioEncontrado.TarjetaProfesional = prmVeterinario.TarjetaProfesional;
                veterinarioEncontrado.Especialidad = prmVeterinario.Especialidad;
                veterinarioEncontrado.Email = prmVeterinario.Email;
                _AppContexto.SaveChanges();
            }
            return veterinarioEncontrado;
        }
        ProfesionalVeterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
        {
            return _AppContexto.ProfesionalVeterinarios.FirstOrDefault(m => m.Id == idVeterinario);
        }

        void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrada = _AppContexto.ProfesionalVeterinarios.FirstOrDefault(m => m.Id == idVeterinario);
            if (VeterinarioEncontrada == null)
                return;
            _AppContexto.ProfesionalVeterinarios.Remove(VeterinarioEncontrada);
            _AppContexto.SaveChanges();
        }
        IEnumerable<ProfesionalVeterinario> IRepositorioVeterinario.GetFiltroVeterinarios(string filtro)
        {
            IEnumerable<ProfesionalVeterinario> listVeterinarios = _AppContexto.ProfesionalVeterinarios; // Obtiene todos las Veterinarios
            if (listVeterinarios != null)  //Si se tienen Veterinarios
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    listVeterinarios = listVeterinarios.Where(m => m.Nombre.Contains(filtro)); 
                }
            }
            return listVeterinarios;
        }
    }
}