using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Shape
{
    public class Circle: Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        private Circle() { }

        public override double GetArea()
        {
            return Math.PI * (Radius * Radius) ;
        }

        public override double GetPerimeter()
        {
            return Math.PI * (2 * Radius);
        }

        public override string ToString()
        {
            string newString = $"This is a {this.GetType().Name} with radius {Radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()}";
            return newString;
        }
    }
}
