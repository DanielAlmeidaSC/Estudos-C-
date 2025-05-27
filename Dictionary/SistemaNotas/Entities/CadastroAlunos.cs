using System;
using System.Collections.Generic;

namespace SistemaNotas.Entities
{
    public class CadastroAlunos
    {
        Dictionary<int, Aluno> Alunos = new Dictionary<int, Aluno>();

        public void AdicionarAlunos(int codigoAluno, string nome, double nota1, double nota2, double nota3)
        {
            if (Alunos.ContainsKey(codigoAluno))
            {
                Console.WriteLine("Esse aluno já existe!");
                return;
            }

            Alunos.Add(codigoAluno, new Aluno(nome, nota1, nota2, nota3));
            Console.WriteLine("Aluno adicionado!");

        }

        public void RemoverAlunos(int codigoAluno)
        {
            if (!Alunos.ContainsKey(codigoAluno))
            {
                Console.WriteLine("Aluno não encontrado!");
                return;
            }

            Alunos.Remove(codigoAluno);
        }

        public void ImprimirRelatorio()
        {
            foreach (KeyValuePair<int, Aluno> aluno in Alunos)
            {
                string juntar = string.Join(", ", aluno.Value.Notas); // pega todos os valores do array e junta, após juntar, ele adiciona a virgula
                Console.WriteLine("Código: "+aluno.Key+" Nome: "+aluno.Value.Nome+" Notas: "+juntar);
            }
        }

    }
}