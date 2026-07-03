using EnumsEx.Entities;
using EnumsEx.Entities.Enums;

namespace EnumsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 13,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            string txt = OrderStatus.Processing.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("PendingPayment");

            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}