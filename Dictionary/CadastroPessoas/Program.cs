using System;
using System.Collections.Generic;
using CadastroPessoas.Entities;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.AdicionarUsuario("Daniel", 20);
            cadastro.AdicionarUsuario("Daniel", 21);
            cadastro.AdicionarUsuario("Daniella", 22);
            cadastro.AdicionarUsuario("Nerci", 55);

            cadastro.ImprimirUsuarios();
        

        }
    }
}
