using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorConstraint<int> prod = new ConstructorConstraint<int>();

            ConstructorConstraint<Product> prod1 = new ConstructorConstraint<Product>();
        }
    }

    internal sealed class ConstructorConstraint<T> where T : new()
    {
        public static T Factory()
        {
            // Allowed because all value types implicitly
            // have a public, parameterless constructor and because
            // the constraint requires that any specified reference
            // type also have a public, parameterless constructor
            return new T();
        }
    }

    public class Product
    {
        private string name;
        public Product()
        {
            this.name = name;
        }
    }
}
