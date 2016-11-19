using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerilizationExample
{
    class Program
    {
        static void Main(string[] args)
        {

            AddressDetails details = new AddressDetails();
            details.HouseNo = 4;
            details.StreetName = "Rohini";
            details.City = "Delhi";
            


            Serialize(details);
        }

        public static void Serialize(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));

            TextWriter writer = new StreamWriter(@"Address.xml");

            serializer.Serialize(writer, details);

        }
    }

    [XmlRoot("Address")]
    public class AddressDetails
    {
        [XmlElement("HouseNumer")]
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        [XmlAttribute]
        public string City { get; set; }
        private string PoAddress { get; set; }
    }
}
