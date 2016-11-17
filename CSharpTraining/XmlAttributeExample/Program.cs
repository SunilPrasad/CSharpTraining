using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlAttributeExample
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //public class AddressDetails
    //{
    //    [XmlElement("Number")]
    //    public int HouseNo { get; set; }
    //    [XmlElement("Street")]
    //    public string StreetName { get; set; }
    //    [XmlElement("City")]
    //    public string CityName { get; set; }
    //}

    //public class AddresssDetails
    //{
    //    [XmlAttribute("Number")]
    //    public int HouseNo { get; set; }
    //    [XmlElement("Street")]
    //    public string StreetName { get; set; }
    //    [XmlElement("CityName")]
    //    public string City { get; set; }
    //}

    //public class AddressDetails
    //{
    //    [XmlElement("Number")]
    //    public int HouseNo;
    //    [XmlElement("Street")]
    //    public string StreetName;
    //    [XmlIgnore]
    //    public string City;
    //}

    //[XmlRoot("Root")]
    //public class AddressDetails
    //{
    //    [XmlElement("Number")]
    //    public int HouseNo;
    //    [XmlElement("Street")]
    //    public string StreetName;
    //    [XmlElement("CityName")]
    //    public string City;
    //}
}
