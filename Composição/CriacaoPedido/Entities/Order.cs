using CriacaoPedido.Enums;
using System.Collections.Generic;
using System.Globalization;


namespace CriacaoPedido.Entities
{
    public class Order
    {
       
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        
        public Client Client { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //cria um método que adiciona itens já com os parametros estabelicidos no construtor de OrderItem 
        public void AddItem(OrderItem orderItem){
            OrderItems.Add(orderItem); 
        }
        //cria um método que Remove itens já com os parametros estabelicidos no construtor de OrderItem 
        public void RemoveItem(OrderItem orderItem){
            OrderItems.Remove(orderItem); 
        }

        public double Total(){

            double result = 0.0;
            foreach (var orderItem in OrderItems)
            {
                result += orderItem.SubTotal();


            }

            return result;
        }

        public void printResult(){
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: "+Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("Client: "+Client.Name+" "+Client.BirthDate.Date+" - "+Client.Email);

            Console.WriteLine("Order Items: ");
            foreach (var item in OrderItems)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Total Price: "+Total().ToString("C", new CultureInfo("en-US")));
        }
    }
}