using System;
namespace ShapeApp
{
    public class Ellipse : Shape
    {
        public double Aaxis { get; set;}
        public double Baxis { get; set; }
        public Ellipse(double a, double b)
        {
            Aaxis = a;
            Baxis = b;
        }
        public override double Area()
        {
            return Math.PI * Aaxis*Baxis;
        }
        public override double Cercumference()
        {
            return Math.PI * (Aaxis+Baxis);
        }
    }
}