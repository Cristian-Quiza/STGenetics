using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
   
   public class RepositorioPaciente: IRepositorioPaciente 
   {
      /// <summary>
      /// Referencia al contexto de Paciente
      /// </summary>

      private readonly AppContexto _AppContexto;

      /// <summary>
      /// Metodo Constructor Utiliza
      /// Inyeccion de dependencias para indicar el contexto a utilizar
      /// </summary>
      /// <param name="AppContexto"></param>//
      /// 
      public RepositorioPaciente(AppContexto AppContexto)
      {
         _AppContexto = AppContexto;
      }

      public RepositorioPaciente()
      {
         
      }

      Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)   
      {
         var pacienteAdicionado = _AppContexto.Pacientes.Add(paciente);
         _AppContexto.SaveChanges();
         return pacienteAdicionado.Entity;

      }
     /* void IRepositorioPaciente.DeletePaciente(int idPaciente)
      {
          var pacienteEncontrado = _AppContexto.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
          if (pacienteEncontrado== null)
              return;
          _AppContexto.Pacientes.Remove(pacienteEncontrado);
          _AppContexto.SaveChanges();
          
      }*/

      
      IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
      {
         return _AppContexto.Pacientes;
      }


      Paciente IRepositorioPaciente.GetPaciente(int idPaciente) 
      {
         return _AppContexto.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
      }

      Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente, int idPaciente)
      {
         var pacienteEncontrado = _AppContexto.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
         if (pacienteEncontrado != null)
         {
            pacienteEncontrado.Nombre = paciente.Nombre;
            pacienteEncontrado.Apellido = paciente.Apellido;
            pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
            pacienteEncontrado.Genero = paciente.Genero;
            pacienteEncontrado.Direccion = paciente.Direccion;
            pacienteEncontrado.Latitud = paciente.Latitud;
            pacienteEncontrado.Longitud = paciente.Longitud;
            pacienteEncontrado.Ciudad = paciente.Ciudad;
            pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
            /*pacienteEncontrado.Familiar = paciente.Familiar;
            pacienteEncontrado.Enfermera = paciente.Enfermera;
            pacienteEncontrado.Medico = paciente.Medico;
            pacienteEncontrado.Historia = paciente.Historia;
            */
            _AppContexto.SaveChanges();
           
         }
         return pacienteEncontrado; 
      }
   
   }

}