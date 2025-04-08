using System;

namespace Programa005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Bem-vindo à calculadora!!*****");

            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Somar;");
            Console.WriteLine("2 - Subtrair;");
            Console.WriteLine("3 - Dividir;");
            Console.WriteLine("4 - Multiplicar");
            double resultado = 0.0d;

            Console.WriteLine("Digite: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                resultado = Somar(numero1, numero2);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                resultado = Subtrair(numero1, numero2);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                resultado = Dividir(numero1, numero2);
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                resultado = Multiplicar(numero1, numero2);
            }



            Console.WriteLine("Resultado = {0}", resultado);

        }


        static double Somar(double numero1, double numero2)
        {
            double calcular = numero1 + numero2;

            return calcular;
        }


        static double Subtrair(double numero1, double numero2)
        {
            double calcular = numero1 - numero2;

            return calcular;
        }

        static double Dividir(double numero1, double numero2)
        {
            double calcular = numero1 / numero2;

            return calcular;
        }

        static double Multiplicar(double numero1, double numero2)
        {
            double calcular = numero1 * numero2;

            return calcular;
        }
    }
}