using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Shape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : this (height) {
            Width = width;
        }


        public Rectangle(double height)
        {
            Width = height;
            Height = height;
        }

        
        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return Width * 2 + Height * 2;
        }

        public override string ToString()
        {

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"This is a {this.GetType().Name} with height {Height} and width {Width}. Area is {GetArea()} and perimeter is {GetPerimeter()}");
            string newString = $"This is a {this.GetType().Name} with height {Height} and width {Width}. Area is {GetArea()} and perimeter is {GetPerimeter()}";
            return newString;
        }


        public override void ScreamHello()
        {
            Console.WriteLine($"{this.GetType().Name} is overriding ScreamHello function!");
        }
    }
}
