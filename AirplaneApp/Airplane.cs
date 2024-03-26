using System;

namespace AirplaneApp
{
    public class Airplane
    {
        public double fuelConsumption;
        public string Model
        {
            get; set;
        }
        public int PassengerCapacity
        {
           get; set;
        }
        public double Range
        {
            get; set;
        }
        public FuelTank Tank
        {
            get; set;
        }
        public List<Passsenger> passsengers;

        public Airplane(int passengerCapacity, double range, int capacity, double level)
        {
            PassengerCapacity = passengerCapacity;
            Range = range;
            Tank = new FuelTank(capacity,level);
            fuelConsumption = capacity/range;
            passsengers = new List<Passsenger>();
        }

        private void addFeul(double liter)
        {
            if(Tank.Level+liter>Tank.Capacity)
            {
                Tank.Level=Tank.Capacity;
            }
            else
            {
                Tank.Level += liter;
            }
            
        }
        public void AddPassenger(Passsenger passsenger)
        {
            passsengers.Add(passsenger);
        }
        public void cruise(double kilometer)
        {
            if(kilometer<=Range&&passsengers.Count!=0)
            {
                if(kilometer>(Tank.Level/fuelConsumption))
                {
                    Console.WriteLine("Fuel level before refilling: "+Tank.Level);
                    addFeul(fuelConsumption*kilometer-Tank.Level);
                }
                Console.WriteLine("Aircraft model: "+Model);
                Console.WriteLine("Current fuel level: "+Tank.Level);

                for(int i=0;i<passsengers.Count;i++)
                {

                    Console.WriteLine("Passenger "+(i+1)+" :"+passsengers[i].TravelID+" "+passsengers.ElementAt(i).Fullname+ " " +passsengers.ElementAt(i).Gender.ToString());
                }
                Console.WriteLine("Landed!");
                Console.WriteLine("Fuel remainig: "+ (Tank.Level-kilometer*fuelConsumption));

            }
        }
        public void removePassenger(Passsenger passsenger)
        {
            passsengers.Remove(passsenger);
        }
    }
}