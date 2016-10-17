using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicitInterfcaeImplementation
{
    //Implicit and Explicit Interface Method Implementations example
    class Program
    {
        static void Main(string[] args)
        {
            SimpleType st = new SimpleType();
            // This calls the public Dispose method implementation
            st.Dispose();

            // This calls IDisposable's Dispose method implementation
            IDisposable d = st;

            d.Dispose();

            
        }
    }

    internal sealed class SimpleType : IDisposable,INewDispose
    {
        void INewDispose.Dispose()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        // public void Dispose() { Console.WriteLine("public Dispose"); }


        void Dispose() { Console.WriteLine("IDisposable Dispose"); }
    }

    interface INewDispose
    {
        void Dispose();
    }
}
