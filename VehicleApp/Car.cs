namespace VehicleApp
{
    public class Car : Vehicle
    {
        public bool HasSunroof { get; set; }
        public Car(string brand, string model, int horsePower, int doors, bool hasSunroof)
            : base(brand, model, horsePower, doors)
        {
            HasSunroof = hasSunroof;
        }
    }
}