﻿using ConsoleAppClassDemo.Interface;

namespace ConsoleAppClassDemo.Classes.ShapeDemo
{
    public class Cuboid : Polygon, I2DShape
    {
        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return 2 * (Width * Length) + Height * Length + Height * Width;
        }

        public double Perimeter()
        {
            return 4 * (Length + Width + Height);
        }


    }
}
