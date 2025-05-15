using System;
using ListaDeVeiculos.Entities;
using System.Collections.Generic;

namespace ListaDeVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(new Moto()); // transformou a subclasse numa superclasse do tipo veiculo
            veiculos.Add(new Carro()); // transformou a subclasse numa superclasse do tipo veiculo

            foreach (var veiculo in veiculos)
            {
                veiculo.LigarMotor();
            }

        }
    }
}