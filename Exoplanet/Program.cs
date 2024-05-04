using Exoplanet;
using System;
using System.Linq;


class Program
{
    static void Main()
    {
        ReliefConditions reliefConditions = new ReliefConditions(1000);

        Console.WriteLine($"Land points: {reliefConditions.CountLandPoints()}");
        Console.WriteLine($"Deepest point index: {reliefConditions.FindDeepestPointIndex()}");
        Console.WriteLine($"Highest point index: {reliefConditions.FindHighestPointIndex()}");
        Console.WriteLine($"Length of measurement under sea level: {reliefConditions.CountUnderSeaLevel()}");
        Console.WriteLine($"Length of measurement above sea level: {reliefConditions.CountAboveSeaLevel()}");
    }
}
