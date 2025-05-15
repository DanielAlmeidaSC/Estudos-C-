using System;
using CursoECargaHoraria.Classes;

namespace CursoECargaHoraria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine()??"0";

            Console.WriteLine("Digite o nome do seu curso: ");
            string nomeCurso = Console.ReadLine()??"0";

            Console.WriteLine("Digite a carga horária do curso: ");
            int cargaHoraria = int.Parse(Console.ReadLine()??"0");

            Curso curso = new Curso(nomeCurso, cargaHoraria);
            Aluno aluno = new Aluno(nome, curso);

            aluno.ImprimirDetalhesDoAluno();
        }
    }
}