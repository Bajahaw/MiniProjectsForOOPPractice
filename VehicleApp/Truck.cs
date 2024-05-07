namespace VehicleApp
{
    public class Truck : Vehicle
    {
        public int BedSize { get; set; }
        public Truck(string brand, string model, int horsePower, int doors, int bedSize)
            : base(brand, model, horsePower, doors)
        {
            BedSize = bedSize;
        }
    }
}