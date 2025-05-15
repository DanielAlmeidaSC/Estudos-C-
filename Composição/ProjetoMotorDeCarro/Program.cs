using System;
using ProjetoMotorDeCarro.Classes;

namespace ProjetoMotorDeCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("***BEM-VINDO À REVENDA DE CARROS USADOS***");
            Console.WriteLine("******************************************");
            Console.WriteLine("\n\n");

            Console.WriteLine("******************************************");
            Console.Write("Digite a marca do seu carro: ");
            string marca = Console.ReadLine()??"0";
            
            Console.Write("Digite o modelo do seu carro: ");
            string modelo = Console.ReadLine()??"0";
            
            Console.Write("Digite o ano do seu carro: ");
            int ano = int.Parse(Console.ReadLine()??"0");
            
            Console.Write("Digite a cor do seu carro: ");
            string cor = Console.ReadLine()??"0";
           
            Console.Write("Digite quantos cavalos de potência tem seu carro do seu carro:");
            int cavalos = int.Parse(Console.ReadLine()??"0");
            Console.WriteLine("******************************************");

            Console.WriteLine("==========================================");
            Console.WriteLine("Qual é a opção correta para o tipo de combustivel do seu automóvel: ");
            Console.WriteLine("1 - Gasolina; ");
            Console.WriteLine("2 - Álcool; ");
            Console.WriteLine("3 - Diesel; ");
            Console.WriteLine("4 - GNV; ");
            Console.WriteLine("5 - Hidrogênio; ");
            Console.WriteLine("6 - Eletricidade. ");
            Console.WriteLine("==========================================");
            Console.Write("Digite: ");
            int opcaoCombustivel = int.Parse(Console.ReadLine()??"0");

            EnumTipoCombustivel tipoCombustivel = (EnumTipoCombustivel)opcaoCombustivel; //função para transformar a opção digitada em um enum

            Motor motor01 = new Motor(cavalos, tipoCombustivel);
            Carro carro01 = new Carro(ano, marca, modelo, cor, motor01);

            carro01.ExibirInfomacoesTotais();

        }
    }
}