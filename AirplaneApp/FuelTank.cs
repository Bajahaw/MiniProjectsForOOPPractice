using System;

namespace AirplaneApp
{
    public class FuelTank
    {
        public int Capacity{get; set;}
        public double Level{get; set;}

        public FuelTank(int capacity, double level)
        {
            Capacity = capacity;
            Level = level;
        }
    }
}