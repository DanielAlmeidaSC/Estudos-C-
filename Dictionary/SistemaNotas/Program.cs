using System;
using SistemaNotas.Entities;

namespace SistemaNotas
{
   class Program
    {
        static void Main(string[] args)
        {
            CadastroAlunos cadastroAlunos = new CadastroAlunos();

            cadastroAlunos.AdicionarAlunos(20319, "Daniel", 6.5, 7.5, 8.5);
            cadastroAlunos.AdicionarAlunos(20320, "Daniel", 6.5, 7.5, 8.5);
            cadastroAlunos.AdicionarAlunos(20318, "Amanda", 8.5, 6.5, 8.5);
            cadastroAlunos.RemoverAlunos(20320);

            cadastroAlunos.ImprimirRelatorio();
        }
    }
}