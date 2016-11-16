using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerilizationAttributesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    public class MyType
    {
        Int32 x, y;[NonSerialized]
        Int32 sum;
        public MyType(Int32 x, Int32 y)
        {
            this.x = x; this.y = y; sum = x + y;
        }
        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            // Example: Set default values for fields in a new version of this type
        }
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            // Example: Initialize transient state from fields
            sum = x + y;
        }
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            // Example: Modify any state before serializing
        }
        [OnSerialized]
        private void OnSerialized(StreamingContext context)
        {
            // Example: Restore any state after serializing
        }
    }
}
