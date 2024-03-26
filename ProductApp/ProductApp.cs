namespace ProductApp
{
    internal class ProductApp
    {
        private static void Main(string[] args)
        {
            Product personalComputer = new Product();
            personalComputer.setCode("PC-001");
            personalComputer.setDateOfOutcome(new DateTime(2022, 9, 9, 15, 30, 32));
            personalComputer.setAvailability(true);
            personalComputer.setName("Home-PC");
            personalComputer.setPrice(1500.3);
            Console.WriteLine(personalComputer.ToString());
        }
    }
}