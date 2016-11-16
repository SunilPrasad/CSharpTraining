using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioSdk;

namespace AddInTypes
{
    public sealed class AddIn_A : IAddIn
    {
        public AddIn_A()
        {
        }
        public String DoSomething(Int32 x)
        {
            return "AddIn_A: " + x.ToString();
        }
    }
    public sealed class AddIn_B : IAddIn
    {
        public AddIn_B()
        {
        }
        public String DoSomething(Int32 x)
        {
            return "AddIn_B: " + (x * 2).ToString();
        }
    }
}
