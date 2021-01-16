using System;
using System.Collections.Generic;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Product> productsList = new List<Product>();

            //Product product = new Product();

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Amasya Elması";
            product1.Price = 5.5;
            product1.Comment = "kırmızı elma";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 55.5;
            product2.Comment = "Diyarbakır Karpuzu";


            Product[] products = new Product[] { product1 , product2 };

            // type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine("-----------------");
            }

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product2);
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product1);


            sepetManager.
        }
    }
}


// Dont repeat yourself - DRY - Clean Code - Best Practice