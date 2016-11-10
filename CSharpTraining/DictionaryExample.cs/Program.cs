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
           
            Dictionary<Customer,string> dictionary = new Dictionary<Customer, string>(1000);

            Customer one = new Customer(100);

            Customer two = new Customer(200);

            Customer three = new Customer(100);

            Customer four = one;


            bool isEqual = one.Equals(three);

            Console.WriteLine(isEqual);



            dictionary.Add(one, "emailIdOne");

            one.Id = 500;

            dictionary.Add(one,"neOne");


          //  dictionary.Add(three, "emailIdThree");

           // dictionary.Add(four, "emailIdOne");

            //dictionary.Add(two, "emailIdTwo");
            //dictionary.Add(three, "emailIdThree");

            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine(string.Format("{0}:{1}", keyValuePair.Key, keyValuePair.Value));
            }


        }

        public class Customer
        {
            public int Id { get; set; }

            public Customer(int id)
            {
                Id = id;
            }

        }

        public class CustomerCompare : IEqualityComparer<Customer>
        {
            public bool Equals(Customer x, Customer y)
            {
                return x.Id.Equals(y.Id);
            }

            public int GetHashCode(Customer obj)
            {
                return obj.Id.GetHashCode();
            }
        }

    }
}
