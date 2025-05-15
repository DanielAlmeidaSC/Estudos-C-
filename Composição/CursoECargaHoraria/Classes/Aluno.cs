namespace CursoECargaHoraria.Classes
{
    public class Aluno
    {
        public string NomeAluno { get; set; }
        public Curso Curso { get; set; }

        public Aluno(string nomeAluno, Curso curso)
        {
            NomeAluno = nomeAluno;
            Curso = curso;
        }

        public void ImprimirDetalhesDoAluno(){
            Console.WriteLine($"{NomeAluno} está matriculado no curso de {Curso.Nome} com carga horária de {Curso.CargaHoraria} horas");

        }
    }
}