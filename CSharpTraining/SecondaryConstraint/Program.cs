using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondaryConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeConstraint<DerivedStream,MyStream> typeConstraint = new TypeConstraint<DerivedStream, MyStream>();
        }
    }

    internal sealed class SecondaryConstraintOfStream<T> where T : Stream, IEnumerable<T>,IComparable<T>
    {
        public void M(T stream)
        {
            
        }
    }

    public class TypeConstraint<T, U> where T : U
    {
        
    }

    public class MyStream 
    {
        
    }

    public class DerivedStream : MyStream
    {
        
    }

    public class NewStream : MyStream
    {
        
    }
}

   
