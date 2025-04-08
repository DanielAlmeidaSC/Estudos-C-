using System;
using System.Globalization;

namespace Programa004 {
    internal class Program {
        static void Main(string[] args) {

            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/

            Console.WriteLine("Digite a quantidade de números pares que vc deseja: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite a base e o divisor: ");
                string[] numeros = Console.ReadLine().Split(' ');

                double baseDivisao = double.Parse(numeros[0]);
                double divisor = double.Parse(numeros[1]);
                
                if(divisor == 0){
                    Console.WriteLine("Impossível");
                    break;
                }
                double calcularResultado = baseDivisao/divisor; 

                Console.WriteLine("Resultado = "+calcularResultado.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}