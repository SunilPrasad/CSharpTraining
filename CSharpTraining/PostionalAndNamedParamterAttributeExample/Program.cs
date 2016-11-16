using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostionalAndNamedParamterAttributeExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [RemarkAttribute("This class uses an attribute.",Review = "",Supplement = "This is additional info.")]
    class UseAttrib
    {
        
    }

    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string pri_remark; // underlies Remark property
        public string Supplement; // this is a named parameter


        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
            Supplement = "None";
        }
        public string Review
        {
            get
            {
                return pri_remark;
            }

            set { pri_remark = value; }
        }
    }
}
