using System;
namespace CustomerApp.Helper
{
    class Convert
    {
        private string countryCode;
        private string providerCode;
        private string firstPart;
        private string secondPart;
        public Convert()
        {
        }
        public static string toHungarianPhoneFormatOf(string phoneNumber)
        {
            Convert convert = new Convert
            {
                countryCode = phoneNumber.Substring(0, 2),
                providerCode = phoneNumber.Substring(2, 4),
                firstPart = phoneNumber.Substring(4, 3),
                secondPart = phoneNumber.Substring(7)
            };
            return $"+{convert.countryCode}/{convert.providerCode}{convert.firstPart}-{convert.secondPart}";
        }
    }
}