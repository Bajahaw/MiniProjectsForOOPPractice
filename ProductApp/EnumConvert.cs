using System;
namespace ProductApp
{
    public class EnumConvert
    {
        public static string toString(Availability availability)
        {
            return availability==Availability.Available? "Available":"Not available";
        }
    }
}