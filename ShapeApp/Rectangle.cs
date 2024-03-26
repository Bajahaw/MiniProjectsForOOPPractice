using System;
namespace ShapeApp
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Name = "Rectangle";
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Cercumference()
        {
            return 2 * (Width + Height);
        }
    }

}