using System;
namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        
        public String Nombre {get; set;}

        public string Apellido {get; set;}

        public string NumeroTelefono {get; set;}

        public Genero Genero {get; set;}

    }
}