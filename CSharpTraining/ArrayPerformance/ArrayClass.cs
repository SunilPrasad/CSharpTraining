using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPerformance
{
    public class ArrayClass
    {
        public void Test()
        {
            int[] intArray = new int[10];

            int[,] twoArray = new int[10,10];

            var result = from c in intArray where c > 10 select c;
        }
    }
}
