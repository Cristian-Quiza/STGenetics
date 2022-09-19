using System;
namespace HomePetCareCats.App.Dominio
{
    public class Propietario : Persona
    {       
        public Mascota Gato {get; set;}

        public string Ciudad {get;set;}
        public string Direccion {get; set;}

        public string Email {get;set;}

    }
}