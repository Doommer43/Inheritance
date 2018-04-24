using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int x, int y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI*Radius*Radius;
        }

        public override double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Position({x},{y}), Radius:{Radius}";
        }
    }
}
