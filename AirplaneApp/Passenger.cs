using System;

namespace AirplaneApp
{
    public enum Gender {Male,Female}
    public class Passsenger
    {
        public int Age{set; get;}
        public string Fullname{set; get;}
        public string TravelID{set; get;}
        public Gender Gender{set; get;}
    }
}