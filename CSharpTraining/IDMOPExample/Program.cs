using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDMOPExample
{
    using System;
    using System.Dynamic;
    public class Test
    {
        static void Main()
        {
            dynamic d = new Duck();
            d.Quack(); // Quack method was called
            d.Waddle(); // Waddle method was called
        }
    }
    public class Duck : DynamicObject
    {
        public override bool TryInvokeMember(
        InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + " method was called");
            result = null;
            return true;
        }
    }
}
