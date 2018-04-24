using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeEntities
{
    public abstract class Shape
    {
        protected int x;
        protected int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public abstract double CalculateArea();

        public abstract double CalculateCircumference();

        public override string ToString()
        {
            return $"Posiotion:({x},{y})";
        }
    }
}
