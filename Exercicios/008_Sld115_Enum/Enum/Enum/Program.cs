using Enum.Entities;
using Enum.Entities.Enums;
using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Para converter um enum para string:
            Console.WriteLine(((int)OrderStatus.Shipped));
            Console.WriteLine(OrderStatus.Shipped.ToString());

        }
    }
}
