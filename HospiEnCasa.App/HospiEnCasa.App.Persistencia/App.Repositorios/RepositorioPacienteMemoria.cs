using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
   public class RepositorioPacienteMemoria : IRepositorioPaciente
   {
      List<Paciente> pacientes;
      public RepositorioPacienteMemoria ()
      {  
         pacientes = new List<Paciente>(){
            new Paciente {Id=100, Nombre="Flor Emilia", Apellido="Gutierrez",NumeroTelefono="3127242012", Genero = Genero.femenino , Direccion="Calle 8c", Latitud=12.0f, Longitud=1.0f, Ciudad="Popayan", FechaNacimiento=new DateTime()},
            new Paciente {Id=200, Nombre="Vanessa", Apellido="Barbosa",NumeroTelefono="3021110012", Genero = Genero.femenino , Direccion="Calle 8c", Latitud=12.0f, Longitud=1.0f, Ciudad="Popayan", FechaNacimiento=new DateTime()},
            new Paciente {Id=300, Nombre="William", Apellido="Perez",NumeroTelefono="3104401282", Genero = Genero.masculino , Direccion="Calle 8c", Latitud=12.0f, Longitud=1.0f, Ciudad="Popayan", FechaNacimiento=new DateTime()}
         };
      }

      IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes(){
         return pacientes;
      }

      Paciente IRepositorioPaciente.AddPaciente(Paciente paciente){
         return new Paciente {Id=100, Nombre="Flor Emilia", Apellido="Gutierrez",NumeroTelefono="3127242012", Genero = Genero.femenino , Direccion="Calle 8c", Latitud=12.0f, Longitud=1.0f, Ciudad="Popayan", FechaNacimiento=new DateTime()};
      }
      Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente, int idPaciente_original){
         return new Paciente {Id=100, Nombre="Flor Emilia", Apellido="Gutierrez",NumeroTelefono="3127242012", Genero = Genero.femenino , Direccion="Calle 8c", Latitud=12.0f, Longitud=1.0f, Ciudad="Popayan", FechaNacimiento=new DateTime()};
      }
      Paciente IRepositorioPaciente.GetPaciente(int idPaciente){
         return pacientes.SingleOrDefault(paciente => paciente.Id==idPaciente);
      }

      
   }
}