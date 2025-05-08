using System;
using System.Globalization;

namespace DivisaoComVar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crie uma variável `var` que recebe o resultado de uma divisão de dois números

            double num1 = 20.0, num2 = 10.5;
            var divisao = num1 / num2; //verifica automaticamente o valor digitado no num1 e num2, sem precisar declarar o tipo
            Console.WriteLine("resultado {0}", divisao.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}