using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 20;

            rectangle.LeftPosition = 0;
            rectangle.TopPosition = 0;


            Circle circle = new Circle();
            circle.Height = 10;
            circle.Width = 20;

            circle.LeftPosition = 0;
            circle.TopPosition = 0;

            Traingle triangle = new Traingle();
            triangle.Height = 10;
            triangle.Width = 20;

            triangle.LeftPosition = 0;
            triangle.TopPosition = 0;

            shapes.Add(rectangle);
            shapes.Add(circle);
            shapes.Add(triangle);

            DrawAnyShape(shapes);


            Rectangle rect = new Rectangle();
            rect.Draw();

            Add(12, 12);
            Add("Hello", "World");            

            
        }

        public static void DrawAnyShape(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }

        public static void Add(int a,int b)
        {

        }

        public static void Add(string a,string b)
        {

        }
    }

    public abstract class Shape
    {
        private int _internalPOstion;
        public int LeftPosition { get; set; }
        public int TopPosition { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing base");
        }
     
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing rectangle");
        }
    }

    public class Circle : Shape
    {      
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing Circle");
        }
    }


    public class Traingle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing traingle");
        }
    }
}
