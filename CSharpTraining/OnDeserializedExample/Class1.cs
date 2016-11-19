using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OnDeserializedExample
{
    public class Program
    {
        public static void Main()
        {
            
        }
    }

    [Serializable]
    internal class Circle
    {
        private Double m_radius;

        [NonSerialized]
        private Double m_area;

        public Circle(Double radius)
        {
            m_radius = radius;
            m_area = Math.PI*m_radius*m_radius;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            m_area = Math.PI * m_radius * m_radius;
        }
    }

}
