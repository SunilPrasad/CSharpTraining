using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDistinctExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = { new Product { Name = "apple", Code = 9 },
                       new Product { Name = "orange", Code = 4 },
                       new Product { Name = "apple", Code = 9 },
                       new Product { Name = "lemon", Code = 12 } };

            //Exclude duplicates.

            var noduplicates = from p in products
                group p by p.Name
                into prod
                select new {Product = prod.First()};


            foreach (var product in noduplicates)
            {
                Console.WriteLine(product.Product.Name);
            }

        }

        private static void DistinctExample()
        {
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            IEnumerable<int> distinctAges = ages.Distinct();

            Console.WriteLine("Distinct ages:");

            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
