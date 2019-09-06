using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure02
{
    class Program
    {
        struct product
        {
            public string id,name;
            public double price;
            public int unit;
        }

        static void Main(string[] args)
        {
            product product = new product();
            Console.Write("Input product id : ");
            product.id = Console.ReadLine();
            Console.Write("Input product name : ");
            product.name = Console.ReadLine();
            Console.Write("Input product unit : ");
            product.unit = int.Parse(Console.ReadLine());
            while (product.unit <= 0)
            {
                Console.Write("Input product unit,again : ");
                product.unit = int.Parse(Console.ReadLine());
            }
            Console.Write("Input product price : ");
            product.price = double.Parse(Console.ReadLine());
            while (product.price <= 0)
            {
                Console.Write("Input product price,again : ");
                product.price = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");

            double total = product.unit * product.price;
            Console.WriteLine($"Product Name : {product.name} ({product.id})");
            Console.WriteLine($"Product Unit : {product.unit} ({product.price:n2} per unit)");
            Console.WriteLine($"Total price : {total:n2} baht.");
            Console.ReadKey();
        }
    }
}
