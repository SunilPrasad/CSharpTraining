using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceWithSameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MarioPizzeria mp = new MarioPizzeria();
            // This line calls MarioPizzeria's public GetMenu method
            mp.GetMenu();
            // These lines call MarioPizzeria's IWindow.GetMenu method
            IWindow window = mp;
            window.GetMenu();
            // These lines call MarioPizzeria's IRestaurant.GetMenu method
            IRestaurant restaurant = mp;
            restaurant.GetMenu();
        }
    }

    // This type is derived from System.Object and
    // implements the IWindow and IRestaurant interfaces.
    public sealed class MarioPizzeria : IWindow, IRestaurant
    {
        // This is the implementation for IWindow's GetMenu method.
        Object IWindow.GetMenu() { return 10; }
        // This is the implementation for IRestaurant's GetMenu method.
        Object IRestaurant.GetMenu() { return 20; }
        // This (optional method) is a GetMenu method that has nothing
        // to do with an interface.
        public Object GetMenu() { return 20; }
    }

    public interface IWindow
    {
        Object GetMenu();
    }
    public interface IRestaurant
    {
        Object GetMenu();
    }
}
