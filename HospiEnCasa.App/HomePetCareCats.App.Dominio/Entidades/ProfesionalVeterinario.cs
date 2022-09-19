namespace HomePetCareCats.App.Dominio
{
    public class ProfesionalVeterinario : Persona
    {
        public string TarjetaProfesional {get;set;}
        public string Especialidad {get;set;}
        public string Email {get;set;}
        public System.Collections.Generic.List<Visita> visita { get; set; }

    }
}