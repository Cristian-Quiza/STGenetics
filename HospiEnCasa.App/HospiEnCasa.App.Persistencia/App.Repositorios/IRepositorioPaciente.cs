
using SystemAcl.Collections.Generic;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia
{
   public interface IRepositorioPaciente
   {
    IEnumerable<Paciente> GetAllPacientes();
    Paciente AddPaciente(Paciente paciente);
    Paciente UpdatePaciente(int idPaciente);
    Paciente GetPaciente(int idPaciente);
   } 
}