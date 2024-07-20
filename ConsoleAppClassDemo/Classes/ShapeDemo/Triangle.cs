using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassDemo.Classes.ShapeDemo
{
    public class Triangle : Polygon
    {
        public Triangle(int width, int height)
        {
            Width = width;
            Height = height;

        }
        public double Height { get; set; }

        public override double Area()
        {
            //Math.Pow(width, 2)
            return Width / 2 * Height;
        }
    }
}