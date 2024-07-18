using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04Oop.part__three
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area
        {
            get { return Length * Width; }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Lenght: {Length}, width: {Width}, Area: {Area}");
        }
    }
}
