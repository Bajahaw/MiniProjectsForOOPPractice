using System;
namespace ShapeApp
{
    public class Traingle:Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Traingle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double Cercumference()
        {
            return Side1 + Side2 + Side3;
        }
        public override double Area()
        {
            double s = ((Side1+Side2+Side3)/2);
            return Math.Sqrt(s*(s-Side1)*(s-Side2)*(s-Side3));
        }
    }
}