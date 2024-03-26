using System;
namespace ShapeApp
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5.5);
            Ellipse ellipse = new Ellipse(5.5,10.5);
            Rectangle rectangle = new Rectangle(5.5,10.5);
            Square square = new Square(5.5);
            Traingle traingle = new Traingle(5.5,5.5,5.5);
            Console.WriteLine("Circle Area: "+circle.Area() + "\nCircle circumference: "+ circle.Cercumference());
            Console.WriteLine("Ellipse Area: "+ellipse.Area() + "\nEllipse circumference: "+ ellipse.Cercumference());
            Console.WriteLine("Rectangle Area: "+rectangle.Area() + "\nRectangle circumference: "+ rectangle.Cercumference());
            Console.WriteLine("Square Area: "+square.Area() + "\nSqhare circumference: "+ square.Cercumference());
            Console.WriteLine("Traingle Area: "+traingle.Area() + "\nTraingle circumference: "+ traingle.Cercumference());
        }
        
        
    }
}