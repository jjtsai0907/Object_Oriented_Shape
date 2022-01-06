using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Shape
{
    public class Square : Shape
    {

        public double SideLength { get; set; }

        public Square (double sideLength)
        {
            SideLength = sideLength;
        }

        private Square() { }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public override double GetPerimeter()
        {
            return SideLength * 4;
        }

        public override string ToString()
        {
            string newString = $"This is a {this.GetType().Name} with side length {SideLength}, area {GetArea()} and perimeter length {GetPerimeter()}.";
            return newString;
        }
    }
}
