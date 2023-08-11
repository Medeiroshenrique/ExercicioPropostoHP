using System;
using System.Globalization;

namespace ExercicioPropostoHP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of products:");
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            
            for (int counter = 1; counter <= numberOfProducts; counter++) {
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char ProductType = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Price:");
                double Price = double.Parse(Console.ReadLine());
                
                if (ProductType == 'c')
                    products.Add(new Product(Name, Price));
                else if (ProductType == 'u')
                {
                    Console.WriteLine("Manufacture date: (DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                
                    products.Add(new UsedProduct(Name, Price, date));
                }else if (ProductType == 'i')
                {
                    Console.WriteLine("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(Name,Price,customsFee));
                }
                else
                {
                    Console.WriteLine("Invalid option, please type again.");
                    counter -= 1;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PRICE TAGS");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
            Console.ResetColor();
        }
    }
}