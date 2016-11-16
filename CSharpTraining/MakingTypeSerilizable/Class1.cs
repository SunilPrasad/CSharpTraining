using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MakingTypeSerilizable
{
    [Serializable]
    internal struct Point
    {
        public Int32 x, y;
    }

    public class Program
    {
        public static void Main()
        {
            Point pt = new Point { x = 1, y = 2 };
            Employee e = new Employee();
            using (var stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, e); // throws SerializationException
            }
        }
    }

    
    public class Person
    {
        
    }

    [Serializable]
    public class Employee : Person
    {
        
    }
   
}
