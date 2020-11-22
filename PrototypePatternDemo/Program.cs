using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            List<Shape> shapeClones = new List<Shape>();
            Square square1 = new Square();
            square1.setId("sq1");
            square1.side = 5;
            Circle circle1 = new Circle();
            circle1.setId("cr1");
            circle1.radius = 5;
            Rectangle rect1 = new Rectangle();
            rect1.setId("re1");
            rect1.width = 5;
            rect1.height = 6;            
            shapes.Add(square1);
            shapes.Add(circle1);
            shapes.Add(rect1);

            Square squere2 = (Square) square1.Clone();
            Circle circle2 = (Circle) circle1.Clone();
            Rectangle rect2 = (Rectangle) rect1.Clone();
            shapeClones.Add(squere2);
            shapeClones.Add(circle2);
            shapeClones.Add(rect2);

            for (int i = 0; i<shapes.Count; i++)
            {
                if (shapes[i].Equals(shapeClones[i]))
                    Console.WriteLine("shapes[" + i + "] is equal to shapeClones[" + i + "]");
                else
                    Console.WriteLine("shapes[" + i + "] is NOT equal to shapeClones[" + i + "]");
            }



            Console.ReadKey();
        }
    }
}
