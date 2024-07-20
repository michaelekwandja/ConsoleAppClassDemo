using ConsoleAppClassDemo.Interface;

namespace ConsoleAppClassDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Length;
        }

        double I2DShape.Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
