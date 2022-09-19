namespace HomePetCareCats.App.Dominio
{
    public class Mascota
    {
        public int Id {get; set;}
        public string Nombre {get;set;}
        public string Raza {get; set;}
        public int Edad {get; set;}
        public Genero Genero {get;set;}
        public ProfesionalVeterinario Veterinario {get; set;}
    }
}