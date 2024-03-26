using System;
namespace ShapeApp
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public override double Cercumference()
        {
            return 4 * Side; 
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}