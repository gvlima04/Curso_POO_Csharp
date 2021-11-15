using System;
using Sld123.Entities.Enums;
using Sld123.Entities;
using System.Text;

namespace Sld123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthDate);

            Console.WriteLine("\nEnter order data: ");
            
            Console.Write("Status: ");
            OrderStatus status = OrderStatus.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many itens to this order? ");
            int numItens = int.Parse(Console.ReadLine());

            Order order = new Order(status, client);

            for (int i = 1; i <= numItens; i++)
            {
                Console.WriteLine($"\nEnter #{i} data:");
                Console.Write("Product Name: ");
                string nameProd = Console.ReadLine();

                Console.Write("Product Price: ");
                double priceProd = double.Parse(Console.ReadLine());

                Product product = new Product(nameProd,priceProd);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(product,quantity);
                
                order.AddItem(orderItem);

            }

            StringBuilder str = new StringBuilder();
            str.AppendLine("\nORDER SUMARY:");
            str.AppendLine("Order Moment: " + order.Date.ToString());
            str.AppendLine("Order Status: " + order.Status.ToString());
            str.AppendLine("Client: " + order.Client.Name + " - " + order.Client.Email);
            str.AppendLine("Order Itens:");

            foreach (OrderItem item in order.List)
            {
                str.AppendLine(item.Product.Name + ", $" + item.Product.Price.ToString() + " Quantity: " + item.Quantity + " Subtotal: $" + item.SubTotal());

            }

            str.AppendLine("Total price: $" + order.Total());

            Console.WriteLine(str);

        }
    }
}
