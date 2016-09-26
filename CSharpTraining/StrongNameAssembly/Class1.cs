using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonStrongNameAssembly;
namespace StrongNameAssembly
{
    public class LoanCalculatorService
    {
        

        public void CalculatePersonalLoan()
        {
            bool a = true;
            bool c = a ? true : false;

            Console.WriteLine("Hello World!!");
            

            Console.WriteLine(c);

            //NonStrongNameAssembly.LibrarySrvice lib = new LibrarySrvice();
            //Console.WriteLine(lib.GetBook());

        }
    }

    public class SecondClass
    {
        public SecondClass()
        {
            LoanCalculatorService loanCal = new LoanCalculatorService();
            
        }

        
    }
}
