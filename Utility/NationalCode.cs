using System;
namespace Utility
{
    public static class NationalCode
    {
        public static bool Validate(string nationalCode)
        {
            switch (nationalCode)
            {
                case "0000000000":
                case "1111111111":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                    return false;
                    break;
            }
            Int64 number;
            int sum = 0, temp;
            Int64.TryParse(nationalCode, out number);
            if (Math.Log10(number) > 6 && Math.Log10(number) < 10)
            {
                temp = Convert.ToInt16(number % 10);
                number /= 10;
                for (int i = 2; i < 11; i++)
                {
                    sum += Convert.ToInt16(i * (number % 10));
                    number /= 10;
                }
                if (((sum % 11 < 2) && (sum % 11 == temp)) || ((sum % 11 >= 2) && ((11 - sum % 11) == temp)))
                    return true;
            }
            return false;
        }
    }
}
