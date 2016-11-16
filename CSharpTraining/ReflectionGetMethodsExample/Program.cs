using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionGetMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetMethod default Returns all the public methods of the current System.Type

            Type proximitySensorType = typeof(ProximitySensor);

            var methods = proximitySensorType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var methodInfo in methods)
            {
                Console.WriteLine(methodInfo.Name);

                var parameters = methodInfo.GetParameters();

                foreach (var parameterInfo in parameters)
                {
                    Console.WriteLine(" " + parameterInfo.Name);
                }
            }
        }
    }

    public class ProximitySensor : IProximitySensor
    {
        
        public List<Object> GetNearByObjects() { return null;}

        public int GetStatus(){return 0; }

        private int OnStart(){return 0;}

        private int Init(){return 0;}

    }

    public interface IProximitySensor
    {
        List<Object> GetNearByObjects();
        int GetStatus();

    }
}
