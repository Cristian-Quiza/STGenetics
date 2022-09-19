using System;
namespace HomePetCareCats.App.Dominio
{
    public class Visita
    {
        public int Id {get; set;}
        public float Temperatura {get; set;}
        public float Peso {get; set;}
        public string FrecuenciaRespiratoria {get; set;}
        public string EstadoAnimo {get; set;}
        public DateTime FechaVisita {get; set;}
        public string FrecuenciaCardiaca {get; set;}
        public string Recomendaciones {get; set;}
        public ProfesionalVeterinario VeterinarioProfesional {get; set;}        
    
    }
}