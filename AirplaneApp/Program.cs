using System;

namespace AirplaneApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            RandomPassenger randomPassenger = new RandomPassenger();
            Airplane airplane = new Airplane(random.Next(1000),random.NextDouble()*10000+10000,random.Next(1000,30000),random.NextDouble()*100+900);
            airplane.Model = "Boing-777";

            for(int i=0; i<random.Next(0,1000);i++)
            {
                airplane.AddPassenger(randomPassenger.generatePassenger());
            }
            airplane.cruise(random.NextDouble()*10000+10000);

        }
    }
}