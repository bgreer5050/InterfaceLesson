using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLibrary
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int sides, int length) : base(sides, length)
        {
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
