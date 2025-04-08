using System;

namespace Programa002 {
    internal class Program {
        static void Main(string[] args) {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível*/



            Console.WriteLine("****BEM-VINDO AO POSTO DELTA****");

            Console.WriteLine("Escreva o tipo de combustível abastecido: ");
            Console.WriteLine(" 1 - Álcool;");
            Console.WriteLine(" 2 - Gasolina;");
            Console.WriteLine(" 3 - Diesel;");
            Console.WriteLine(" 4 - Fim.");

            Console.Write("Digite: ");
            int opcao = int.Parse(Console.ReadLine());
            int contagemAlcool = 0;
            int contagemGasolina = 0;
            int contagemDiesel = 0;


            while (opcao != 4)
            {
                if(opcao == 1){
                    contagemAlcool++;
                }
                else if(opcao == 2){
                    contagemGasolina++;
                }
                else if(opcao == 3){
                    contagemDiesel++;
                }

                    Console.Write("Digite: ");
                    opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: {0}", contagemAlcool);
            Console.WriteLine("Gasolina: {0}", contagemGasolina);
            Console.WriteLine("Diesel: {0}", contagemDiesel);
        }
    }
}