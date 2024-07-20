namespace ConsoleAppClassDemo.Classes.ShapeDemo
{
    public class Shpere : CircularShape, I3DShape
    {
        public Shpere(double raduis)
        {
            Radius = raduis;
        }
        public double Radius { get; set; }
        public double Circumference()
        {
            return 4 * Math.PI * Math.Pow(Radius, 3);
        }

        public double Volume()
        {
            return 4 / 3 * Math.PI * Radius;
        }
    }
}
