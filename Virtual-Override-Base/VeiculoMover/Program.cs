using System;
using VeiculoMover.Entities;
using System.Collections.Generic;

namespace VeiculoMover
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Cria uma lista de veiculos do tipo Veiculo
            List<Veiculo> veiculos = new List<Veiculo>();
            // Cria carro e bicicleta do tipo veiculo, util pra não precisar ficar instanciando atributo por atributo para imprimir algo genérico
            veiculos.Add(new Carro());
            veiculos.Add(new Bicicleta());

            foreach (Veiculo veiculo in veiculos)
            {
                // Só vai funcionar se der pra sobrescrever, caso não for, ele vai imprimir o molde principal
                veiculo.Mover();

            }
        }
    }
}