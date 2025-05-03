using System;

namespace Programa009 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Peça a data de nascimento do usuário e calcule a idade atual");

            Console.WriteLine("Digite sua data de nascimento: ");
            string dataDeNasc = Console.ReadLine()??"0";

            DateTime dataDeNascimento = DateTime.Parse(dataDeNasc);
            dataDeNascimento.ToString("dd/MM/aaaa");
            
            Console.WriteLine(dataDeNascimento.ToString("D"));


            DateTime hoje = DateTime.Today;
            hoje.ToString("dd/MM/aaaa");

            Console.WriteLine(hoje.ToString("D"));
            int calcular = hoje.Year - dataDeNascimento.Year;

            if(hoje.Month < dataDeNascimento.Month){ // se o mes atual for menor que o mes de nascimento, ele subtrai um ano da data
                calcular -= 1;

                Console.WriteLine("Você tem {0} anos!", calcular); 
            }else{

                Console.WriteLine("Você tem {0} anos!", calcular); //se o mes atual for maior, ele incrementa normalmente 1 ano a mais de vida, já que fez aniversário
            }

        }
    }
}