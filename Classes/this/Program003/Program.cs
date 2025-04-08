using System;

namespace Program003 {
    internal class Program {
        static void Main(string[] args) {

            Pedido pedido = new Pedido();

            Console.WriteLine("Digite o item: ");
            string item = Console.ReadLine()??"0";
            
            Console.WriteLine("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine()??"0");


            pedido.DefinirItem(item);
            pedido.DefinirQuantidade(quantidade);
            
            pedido.Mostrar();

        }
    }
}