using System;
using System.Text;

public sealed class Bang
{
    static Bang()
    {
        Console.WriteLine("In static constructor");
        throw new Exception("Bang!");
    }

    public static void Foo() { }
}

class Test
{
    static void Main()
    {
        System.Text.StringBuilder stringBuilder = new StringBuilder(12);
        stringBuilder.Append("12");
        stringBuilder.Append("123");
        stringBuilder.Append("12345678911");

        for (int i = 0; i < 5; i++)
        {
            try
            {
                Bang.Foo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
