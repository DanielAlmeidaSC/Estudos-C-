using System;

namespace SistemaNotas.Entities
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public double[] Notas { get; set; } = new double[3];

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Notas = new double[] { nota1, nota2, nota3 }; // atribui ao array Notas um novo array com  valores inseridos. Vai aceitar  o new double pq ele é do tipo array
        }
        
        
    }
}