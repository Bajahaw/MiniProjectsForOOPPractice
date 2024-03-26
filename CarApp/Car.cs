using System.Runtime.CompilerServices;

namespace CarApp
{
    class Car
    {
        private string brand;
        private string licensePlateNumber;
        private int startingXPosition;
        private int startingYPosition;
        public Car(string brand, string license, int x, int y)
        {
            this.brand=brand;
            this.licensePlateNumber=license;
            this.startingXPosition=x;
            this.startingYPosition=y;
        }
        public string getBrand()
        {
            return brand;
        }
        public string getLicensePlateNumber()
        {
            return licensePlateNumber;
        }
        public int getStartingXPosition()
        {
            return startingXPosition;
        }
        public int getstartingYPosition()
        {
            return startingYPosition;
        }
        public void accelerate()
        {
            Console.WriteLine("Accelerating!");
        }
        public void move()
        {
            Console.WriteLine("Moving..");
        }
        public void park()
        {
            Console.WriteLine("Parked!");
        }
        public void slowDown()
        {
            Console.WriteLine("Slowing down!");
        }
        public void setBrand(string brand)
        {
            this.brand=brand;
        }
        public void setLicensePlateNumber(string license)
        {
            this.licensePlateNumber=license;
        }
        public void setStartingXPosition(int position)
        {
            this.startingXPosition=position;
        }
        public void setStartingYPosition(int position)
        {
            this.startingYPosition=position;
        }
    }
}