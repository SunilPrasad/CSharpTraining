using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load("PurchaseOrder.xml");

            IEnumerable<XElement> address =
                from el in root.Elements("Address")
                where (string)el.Attribute("Type") == "Billing"
                select el;

            foreach (XElement el in address)
                Console.WriteLine(el);
        }
    }
}
