using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace programa004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não

            System.Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                System.Console.WriteLine("Positivo");
            }else{
                System.Console.WriteLine("Negativo");
            }*/

            /*Par ou ímpar
            
            System.Console.WriteLine("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());


            if(numero % 2 == 0){
                System.Console.WriteLine("Par");
            }else{
                System.Console.WriteLine("ímpar");
            }*/

            /*Ler hora inicial e final de um jogo, calcular a duração do jogo tendo uma duração minima de 1h

            System.Console.WriteLine("Digite a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a hora final do jogo: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int calcular = 0;

            if(horaInicial<horaFinal){
                calcular = horaFinal - horaInicial;
            }else{
                calcular = 24 - horaInicial+horaFinal;
            }

            System.Console.WriteLine("O JOGO DUROU "+calcular+" HORA(S)");*/



            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar.

            System.Console.WriteLine("Código Especificação        Preço");
            System.Console.WriteLine("1      Cachorro Quente      R$4.00");
            System.Console.WriteLine("2      X-salada             R$4.50");
            System.Console.WriteLine("3      X-Bacon              R$5.00");
            System.Console.WriteLine("4      Torrada Simples      R$2.00");
            System.Console.WriteLine("5      Refrigerante         R$1.50");


            System.Console.WriteLine("Digite o código do produto e a quantidade desejada: ");
            string[] codigoEQtd = Console.ReadLine().Split(' ');

            int codigo = int.Parse(codigoEQtd[0]);
            int quantidade = int.Parse(codigoEQtd[1]);
            double total = 0.0D;

            if(codigo == 1){
                total = quantidade * 4.00;    
            }else if(codigo == 2){
                total = quantidade * 4.50;
            }else if(codigo == 3){
                total = quantidade * 5.00;
            }else if(codigo == 4){
                total = quantidade * 2.00;
            }else if(codigo == 5){
                total = quantidade * 1.50;
            }

            System.Console.WriteLine("Total: R$"+total.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            System.Console.WriteLine("Digite um número: ");
            double numeroDigitado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numeroDigitado >= 0 && numeroDigitado <= 25){
                System.Console.WriteLine("Intervalo: 0 a 25");
            }else if(numeroDigitado >= 25 && numeroDigitado <= 50){
                System.Console.WriteLine("Intervalo: 25 a 50");
            }else if(numeroDigitado >= 50 && numeroDigitado <= 75){
                System.Console.WriteLine("Intervalo: 50 a 75");
            }else if(numeroDigitado >= 75 && numeroDigitado <= 100){
                System.Console.WriteLine("Intervalo: 75 a 100");
            }else{
                System.Console.WriteLine("Fora de intervalo");
            }

            */

            

        }
    }
}