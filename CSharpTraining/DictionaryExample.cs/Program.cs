using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, Customer>();

            Customer customer = new Customer();

            customer.Id = 12345;

            dictionary.Add(customer.Id, customer);


            //             * var dictionary = new Dictionary<int, Customer>
            //{
            //     { customer1.Id, customer1 },
            //     { customer2.Id, customer2 }
            //}
            //             * 
            //             * 
            //        }

            var customer1 = dictionary[1234];

            // Removing an object by its key
            dictionary.Remove(1);

            // Removing all objects
            dictionary.Clear();


            var count = dictionary.Count;

            var containsKey = dictionary.ContainsKey(1);

            var containsValue = dictionary.ContainsValue(customer1);

            // Iterate over keys 
            foreach (var key in dictionary.Keys)
                Console.WriteLine(dictionary[key]);

            // Iterate over values
            foreach (var value in dictionary.Values)
                Console.WriteLine(value);

            // Iterate over dictionary
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine(keyValuePair.Key);
                Console.WriteLine(keyValuePair.Value);
            }
        }

        public class Customer
        {
            public int Id { get; set; }

        }

    }
}
