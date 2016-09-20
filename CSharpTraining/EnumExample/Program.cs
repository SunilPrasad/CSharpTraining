using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    using System;

    class Example
    {
        // Define an Enum without FlagsAttribute.
        enum SingleHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        // Define an Enum with FlagsAttribute.
        [FlagsAttribute]
        enum MultiHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        static void Main()
        {
            MultiHue redGreen = MultiHue.Red | MultiHue.Green;
            
            SingleHue singleHue = SingleHue.Red | SingleHue.Green;

            Console.WriteLine(singleHue);

            Console.WriteLine(redGreen);
            
        }

        public static void PrintAllPossibleValuesOFEnum()
        {
            // Display all possible combinations of values.
            Console.WriteLine(
                 "All possible combinations of values without FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (SingleHue)val);

            // Display all combinations of values, and invalid values.
            Console.WriteLine(
                 "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);
        }
    }
}
