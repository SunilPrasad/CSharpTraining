using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type testClassType = typeof(CalculatorTests);

            var customAttributes = testClassType.GetCustomAttributes();

            foreach (var customAttribute in customAttributes)
            {
                if (customAttribute.GetType() == typeof(TestClassAttribute))
                {
                    var testClassAttribute = (TestClassAttribute) customAttribute;

                    Console.WriteLine(testClassAttribute.Name);
                    Console.WriteLine(testClassAttribute.Level);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class TestClassAttribute : Attribute
    {
        // Private fields.
        private string name;
        private string level;
        private bool reviewed;

        // This constructor defines two required parameters: name and level.

        public TestClassAttribute(string name, string level)
        {
            this.name = name;
            this.level = level;
        }

        public string Name
        {
            get { return name; }
        }

        public string Level
        {
            get { return level; }
        }
    }


    [TestClass("Name", "Unit")]
    public class CalculatorTests
    {
        public void TestSum()
        {
           Console.WriteLine("Test sum");
        }
    }
}
