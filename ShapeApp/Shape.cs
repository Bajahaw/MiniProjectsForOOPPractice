using System;
namespace ShapeApp
{
    public class Shape
    {
        public string Name { get; set; }

        public Shape()
        {
            Name = "Shape";
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Cercumference()
        {
            return 0;
        }
    }
}