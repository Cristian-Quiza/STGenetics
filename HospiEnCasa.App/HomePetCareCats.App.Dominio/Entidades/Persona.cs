using System;
namespace HomePetCareCats.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        
        public string Nombre {get; set;}

        public string Apellido {get; set;}

        public int Edad {get; set;}

        public string NumeroTelefono {get; set;}

        public Genero Genero {get; set;}

    }
}