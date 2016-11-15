using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDistinctExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            var filteredCollection = from a in ages
                                     where a > 30
                                     select a;

            var count = filteredCollection.ToList();

            foreach (var i in filteredCollection)
            {
                
            }

        }
      
    }


}
