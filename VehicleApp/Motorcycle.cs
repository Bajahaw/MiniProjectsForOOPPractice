namespace VehicleApp
{
    public class Motorcycle : Vehicle
    {
        public int EngineSize { get; set; }
        public Motorcycle(string brand, string model, int horsePower, int doors, int engineSize)
            : base(brand, model, horsePower, doors)
        {
            EngineSize = engineSize;
        }
    }
}