using System;

namespace TextApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("Raaaadhi");
            Console.WriteLine(text.getConsonantsNumber());
        }
    }
}