namespace VehicleApp
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int Doors { get; set; }
        public Vehicle(string brand, string model, int horsePower, int doors)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
            Doors = doors;
        }
    }
}