using System;
using ProjetoRetornarCarros;

namespace ProjetoRetornarCarros
{
    public class Project
    {
        static void Main(string[]args)
        {
            Console.Write("Digite a marca do seu carro: ");
            string marca = Console.ReadLine()??"0";

            Console.Write("Digite o modelo do seu carro: ");
            string modelo = Console.ReadLine()??"0";
           
            Console.Write("Digite a cor do seu carro: ");
            string cor = Console.ReadLine()??"0";
           
            Console.Write("Digite o ano do seu carro: ");
            int ano = int.Parse(Console.ReadLine()??"0");

            Carro carro = new Carro(marca, modelo, cor, ano);
            
            carro.ImprimirInformacoes();
            
        }        
    }
}