using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public class Square : Rectangle
    {
        public Square(int x, int y, double length) : base(x, y, length, length)
        {

        }

        public override string ToString()
        {
            return $"Position:({x},{y}), Length:{Length}";
        }
    }
}
