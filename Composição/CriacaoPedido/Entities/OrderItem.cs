using System.Globalization;

namespace CriacaoPedido.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal(){
            double result = Quantity * Price;
            return result;
        }

        public override string ToString()
        {
            return $"{Product.Name}, {Product.Price.ToString("C", new CultureInfo("en-US"))}, Quantity: {Quantity}, Subtotal: {SubTotal().ToString("C", new CultureInfo("en-US"))}";
        }
    }
}