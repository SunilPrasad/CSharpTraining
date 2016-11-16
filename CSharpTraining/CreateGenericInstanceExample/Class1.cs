using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenericInstanceExample
{
    public static class Program
    {
        internal sealed class Dictionary<TKey, TValue> { }

        public static void Main()
        {
            // Get a reference to the generic type's type object
            Type openType = typeof(Dictionary<,>);

            // Close the generic type by using TKey=String, TValue=Int32
            Type closedType = openType.MakeGenericType(typeof(String), typeof(Int32));

            // Construct an instance of the closed type
            Object o = Activator.CreateInstance(closedType);

            // Prove it worked
            Console.WriteLine(o.GetType());
        }
    }
}
