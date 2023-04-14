using System.Globalization;
using Exercicio3Enum.Entities;
using Exercicio3Enum.Entities.Enums;

namespace Exercicio3Enum
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Brith date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int itemOrders = int.Parse(Console.ReadLine());
            Order order = new Order();
            Client client = new Client(name, email, birthDate);
            order.Client = client;
            order.Status = status;
            
            for (int i = 1; i <= itemOrders; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int orderQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(orderQuantity, productPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}