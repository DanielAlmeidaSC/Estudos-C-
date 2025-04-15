using System;

namespace Programa005 {
    internal class Program {
        static void Main(string[] args) {

            Aluno aluno1 = new Aluno("Daniel", 6.5, 7.5);
            Aluno aluno2 = new Aluno("Amanda", 7.5, 5.5);
            Aluno aluno3 = new Aluno("Ariele", 9.5, 10.0);
            Aluno aluno4 = new Aluno("Jéssica", 8.0, 7.5);
            Aluno aluno5 = new Aluno("Roberta", 4.5, 9.5);
            Aluno aluno6 = new Aluno("Renata", 9.5, 3.5);

            Console.WriteLine("Média de "+aluno1.Nome+": "+aluno1.Media);
            Console.WriteLine("Média de "+aluno2.Nome+": "+aluno2.Media);
            Console.WriteLine("Média de "+aluno3.Nome+": "+aluno3.Media);
            Console.WriteLine("Média de "+aluno4.Nome+": "+aluno4.Media);
            Console.WriteLine("Média de "+aluno5.Nome+": "+aluno5.Media);
            Console.WriteLine("Média de "+aluno6.Nome+": "+aluno6.Media);            

        }
    }
}