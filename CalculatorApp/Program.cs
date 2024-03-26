using System;
namespace CalculatorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double a = calculator.Add(5.6,4.7);
            Console.WriteLine(a);
        }
    }
}