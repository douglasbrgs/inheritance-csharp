using Course.Entities;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>(n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i + 1} data: ");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product;

                if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");

                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product = new UsedProduct(name, price, manufactureDate);
                }
                else if (type == 'i')
                {
                    Console.Write("Customs fee: ");

                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product = new ImportedProduct(name, price, customsFee);
                }
                else
                {
                    product = new Product(name, price);
                }

                products.Add(product);
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (var pro in products)
            {
                Console.WriteLine(pro.PriceTag());
            }
        }
    }
}