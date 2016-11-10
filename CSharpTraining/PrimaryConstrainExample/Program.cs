using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstrainExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal sealed class PrimaryConstraintOfStream<T> where T : Stream
    {
        public void M(T stream)
        {
            stream.Close();// OK
        }
    }

    internal sealed class PrimaryConstraintOfClass<T> where T : class
    {
        public void M()
        {
            T temp = null;// Allowed because T must be a reference type
        }
    }

    internal sealed class PrimaryConstraintOfStruct<T> where T : struct
    {
        public static T Factory()
        {
            // Allowed because all value types implicitly
            // have a public, parameterless constructor
           return new T();
        }
    }
}
