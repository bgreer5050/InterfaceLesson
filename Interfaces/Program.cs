using PolygonsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(5); //Create a square
            DisplayPolygon("Triangle", triangle);  //Display the squares properties

            Console.Read();
        }

        private static void DisplayPolygon(string strShape, dynamic shape)
        {
            Console.WriteLine(strShape + " Number of Sides: " + shape.NumberOfSides);
            Console.WriteLine(strShape + " Side Length: " + shape.SideLength);
            Console.WriteLine(strShape + " Perimiter: " + shape.GetPerimeter());
            Console.WriteLine(strShape + " Area: " + shape.GetArea());

                
        }
    }
}
