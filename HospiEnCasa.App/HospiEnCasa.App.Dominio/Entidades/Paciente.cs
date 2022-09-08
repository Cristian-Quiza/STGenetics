using System;
namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente que esta en atencion hospitalaria
    /// </summary>   
    public class Paciente : Persona
    {
        public string Direccion { get; set; }
        /// Coordenada de la dirección del Paciente
        public float Latitud { get; set; }
        /// Coordenada de la dirección del Paciente
        public float Longitud { get; set; }
        // Ciudad de residencia del Paciente
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}