using System;
using System.Security.Cryptography;
namespace RhombusApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Rhombus rhombus = new Rhombus((float)(random.NextDouble()*20+5),(float)(random.NextDouble()*20));
            Console.WriteLine(rhombus.ToString());
            int size = (int)rhombus.getA(); 

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" "); 
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine(); 
            }
            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" "); 
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine(); 
            }
        }
    }
}