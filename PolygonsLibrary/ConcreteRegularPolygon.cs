using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public class ConcreteRegularPolygon
    {


        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        /// <summary>
        /// The calculation of GetArea is different depending on how many sides the Polygon has
        /// We will throw a not implemented exception and it will be up to the child class to override
        /// this method.
        /// </summary>
        /// <returns></returns>
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
