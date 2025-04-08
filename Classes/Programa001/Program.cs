using System;

namespace Programa001 {
    internal class Program {
        static void Main(string[] args) {

            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Digite seu nome: ");
            pessoa2.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());


            if(pessoa1.idade>pessoa2.idade){
                Console.WriteLine("{0} é mais velho(a)!", pessoa1.nome);
            }else{
                Console.WriteLine("{0} é mais  velho(a)!", pessoa2.nome);
            }

        }
    }
}