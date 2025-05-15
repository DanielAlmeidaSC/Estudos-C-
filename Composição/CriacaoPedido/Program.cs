using System;
using System.Globalization;
using CriacaoPedido.Entities;
using CriacaoPedido.Enums;

namespace CriacaoPedido
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data: ");
            
            Console.Write("Name: ");
            string name = Console.ReadLine()??"0";

            Console.Write("Email: ");
            string email = Console.ReadLine()??"0";

            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()??"0");

            Console.Write("Enter order data: ");
            string statusOrder = Console.ReadLine()??"0";

            Enum.TryParse(statusOrder, true, out OrderStatus status);
            
            Client client = new Client(name, email, birthDate);

            Order order = new Order(DateTime.Now, status, client);


            Console.Write("How many items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine()??"0");

            for (int i = 0; i < quantityItems; i++)
            {
                Console.WriteLine("Enter #{0} item data:", i+1);
               
                Console.Write("Product name: ");
                string productName = Console.ReadLine()??"0";

                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine()??"", CultureInfo.InvariantCulture);

                Console.WriteLine("Quantity: ");
                int quantityProducts = int.Parse(Console.ReadLine()??"0");

                Product product = new Product(productName, productPrice);

                OrderItem orderItem = new OrderItem(quantityProducts, productPrice, product);

                order.AddItem(orderItem);
            }

            order.printResult();
            





        }
    }
}