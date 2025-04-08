using System;
using System.Runtime.Intrinsics.Arm;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {

            /*
            Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/

            Console.Write("Qual a quantidade de valores inteiros que deseja: ");
            int quantidade = int.Parse(Console.ReadLine());
            int em = 0;
            int fora = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Digite: ");
                int numero = int.Parse(Console.ReadLine());

                if(numero >= 10 && numero <= 20){
                    em++;
                }else{
                    fora++;
                }
            }

            Console.WriteLine("{0} on", em);
            Console.WriteLine("{0} out", fora);

        }
    }
}