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
        }
    }
}