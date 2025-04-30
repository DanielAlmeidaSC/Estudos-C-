using System;
using System.Globalization;

namespace Programa003{
    internal class Program{
        static void Main(string[]args){
           /* System.Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string[] separar = palavra.Split(' ');

          
            for (int i = 0; i < palavra.Length; i++)
            {
                System.Console.WriteLine(separar[i]); //precisa ser posto posição por posição, pois cada palavra ficará armazenada em um i
            }*/

            /*
            System.Console.WriteLine("Digite três frutas: ");
            string[] frutas = Console.ReadLine().Split(' '); // separa por espaço 

            string primeiraFruta = (frutas[0]);
            string segundaFruta = (frutas[1]);
            string terceiraFruta = (frutas[2]);

            System.Console.WriteLine(primeiraFruta);
            System.Console.WriteLine(segundaFruta);
            System.Console.WriteLine(terceiraFruta);*/

            /*Fazer um programa para executar interação com usuario, ler valores e depois mostrar os dados na tela*/

            System.Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            System.Console.Write("Quantos quartos tem na sua casa: ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            System.Console.Write("Entre com o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Entre com seu último nome, idade e altura na mesma linha: ");
            string[] vetNomeIdadeAltura = Console.ReadLine().Split(' ');

            string ultimoNome = (vetNomeIdadeAltura[0]);
            string idade = (vetNomeIdadeAltura[1]);
            double altura = double.Parse(vetNomeIdadeAltura[2], CultureInfo.InvariantCulture);
            
            System.Console.WriteLine("-----------------------------------------------------");
            System.Console.WriteLine("Nome completo: "+nome);
            System.Console.WriteLine("Quantidade de quartos: "+qtdQuartos);
            System.Console.WriteLine("Preço produto: "+precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Último nome: "+ultimoNome);
            System.Console.WriteLine("Idade: "+idade);
            System.Console.WriteLine("Altura: "+altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}