using System;
using TesteEnumEComposicao.Entities;
using TesteEnumEComposicao.Entities.Enums;

namespace TesteEnumEComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
         /* aula 122
            Ler os dados de um pedido com N itens(N fornecido pelo usuário).Depois, mostrar um
            sumário do pedido conforme exemplo.Nota: o instante do pedido deve ser
            o instante do sistema: DateTime.Now*/
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date(DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order ? ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productname = Console.ReadLine();

                Console.Write("Product price: ");
                double productprice = double.Parse (Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productname,productprice);

                OrderItem orderitem = new OrderItem(quantity,productprice, product);

                order.AddItem(orderitem);
            }

            Console.WriteLine(order.ToString()); //pode colocar só order que o sistema entende que é o tostring, mas prefiro explicitar
        }
    }
}
