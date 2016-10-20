using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPerformanceComp
{
    public class ProgramOne
    {
        public void Test()
        {
            int[,] intArray = new int[10, 20];

            int[][] intJaggedArray = new int[10][];

            intArray[0,0] = 10;

            Console.WriteLine(intArray[0, 0]);

            intJaggedArray[0] = new int[20];

            intJaggedArray[0][0] = 20;

            Console.WriteLine(intJaggedArray[0][0]);
        }
    }
}
