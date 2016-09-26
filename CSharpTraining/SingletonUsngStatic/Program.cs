using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonUsngStatic
{
    public sealed class Singleton
    {
        private static readonly Singleton instance;
        // Explicit static constructor to tell C# compiler    
        // not to mark type as beforefieldinit    static Singleton()  
        static Singleton()
        {
            instance = new Singleton();
        }
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

}
