using System;
using System.Globalization;
using System.Security.Principal;

namespace Programa002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.");

            int a = 10;
            int b = 30;

            int soma = a + b;

            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("A soma dos valores é {0}", soma);

            int c = -30;
            int d = 10;

            int soma2 = c + d;

            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Segunda soma = {0}", soma2);
            System.Console.WriteLine("------------------------------------");

            System.Console.WriteLine("Exercício 2:");
            System.Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais.");
            System.Console.WriteLine("Fórmula da área: area = π . raio2");
            System.Console.WriteLine("Considere o valor de π = 3.14159");

            double pi = 3.14159;

            System.Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            System.Console.WriteLine("Resultado: " + area.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("--------------------------------");
            

            System.Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).");

            System.Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o quarto número: ");
            int num4 = int.Parse(Console.ReadLine());

            int diferenca = (num1*num2 - num3 *num4);

            System.Console.WriteLine("Diferença = {0}", diferenca);


            System.Console.WriteLine("Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.");

            int horasTrabalhadas = 0;
            double valorRecebidoPorHora = 0;
            double calcularSalario = 0;

            System.Console.WriteLine("Digite seu código: ");
            string codigo = Console.ReadLine();

            System.Console.WriteLine("Quantas horas você trabalhou: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Quanto você recebe por hora: ");
            valorRecebidoPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calcularSalario = horasTrabalhadas * valorRecebidoPorHora;

            System.Console.WriteLine("Código:{0}", codigo);
            System.Console.WriteLine("Número de horas trabalhadas: {0}", horasTrabalhadas);
            System.Console.WriteLine("Salário: R$"+calcularSalario.ToString("F2", CultureInfo.InvariantCulture) );
            
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            System.Console.WriteLine("Digite o código, a quantidade e o preço do produto: ");
            String[] dadosDigitados = Console.ReadLine().Split(' '); //vai separar cada posição do vetor depois de cada espaço

            int codigo1 = int.Parse(dadosDigitados[0]); //vai armazenar o codigo digitado
            int quantidade1 = int.Parse(dadosDigitados[1]);
            double precoUnitario1 = double.Parse(dadosDigitados[2], CultureInfo.InvariantCulture);
        
            System.Console.WriteLine("Digite o código, a quantidade e o preço do produto: ");
            string[] dadosDigitados2 = Console.ReadLine().Split(' ');

            int codigo2 = int.Parse(dadosDigitados2[0]);
            int quantidade2 = int.Parse(dadosDigitados2[1]);
            double precoUnitario2 = double.Parse(dadosDigitados2[2], CultureInfo.InvariantCulture);

            double total = quantidade1*precoUnitario1 + quantidade2*precoUnitario2;


            System.Console.WriteLine("Total: "+total.ToString("F2", CultureInfo.InvariantCulture));*/
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/
            

            double a = 12.7;
            double b = 10.4;
            double c = 15.2;

            double AreaTriangulo = (a * c) / 2; //a = base c - altura
            double areaCirculo = (3.14159*(Math.Pow(c, 2)));
            double areaTrapezio = ((a+b)*c)/2;
            double areaQuadrado = Math.Pow(b,2);
            double areaRetangulo = a*c;

            System.Console.WriteLine("Triangulo: "+AreaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Circulo: "+areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Trapézio: "+areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Quadrado: "+areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Retângulo: "+areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}