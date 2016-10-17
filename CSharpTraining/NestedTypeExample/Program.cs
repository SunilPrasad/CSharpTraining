using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace NestedTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
           // Container container = new Container("Name");

          //  Container.Nested nestedClass = new Container.Nested(container);

            Container.Nested nestedClass = new Container.Nested();

        }
    }

    public class Container
    {
        private string _name;
        public string Name { get; set; }
        private Nested _nested;

        public Container(string name)
        {
            _name = name;
            _nested = new Nested(this);            
        }


        public class Nested
        {
            private Container parent;
            private string _nestedName;

            public Nested()
            {

            }

            public Nested(Container parent)
            {
                this.parent = parent;
                Console.WriteLine(parent._name);
            }
        }
    }
}
