using System;
namespace CircleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int N = 3;
            for(int i=0; i<N; i++)
            {
                Console.WriteLine("Enter a double value:");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double r))
                {
                    
                    Circle circle = new Circle(r);
                    Console.WriteLine(circle.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid double value.");
                }
            }
        }
    }
}