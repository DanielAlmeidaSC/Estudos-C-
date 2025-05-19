using System;
using HerancaMultipla.Entities;

namespace HerancaMultipla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Aluno();
            pessoa.MostrarInfo();
            Aluno aluno = new AlunoBolsista();
            aluno.MostrarInfo();

        }
    }
}