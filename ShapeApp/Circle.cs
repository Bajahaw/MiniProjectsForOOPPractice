using System;
namespace ShapeApp
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
            Name = "Circle";
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;   
        }

        public override double Cercumference()
        {
            return 2 * Radius * Math.PI;
        }
    }

}