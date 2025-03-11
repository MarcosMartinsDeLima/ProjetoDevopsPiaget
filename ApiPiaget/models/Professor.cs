namespace ApiPiaget.models
{
    public class Professor
    {  
        public Guid Id { get; set; }
        public string? Nome { get; set; } 
        public string? RGM { get; set; } 
        public string? CPF { get; set; } 
        public Aluno? Aluno { get; set; }
        public string? Materia { get; set; }
    }
}