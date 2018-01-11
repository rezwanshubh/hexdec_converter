using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec_Converter
{
    public static class ConverterData
    {


        public static string[] GetNumbers(string fullString, string[] separator)
        {
            string[] parts1 = fullString.Split(separator, StringSplitOptions.None);

            return parts1;
        }

        public static string ConvertToHex(string decValue)
        {
            return Convert.ToInt64(decValue).ToString("X");
        }

        public static decimal ConvertToDec(string hexValue)
        {
            //return int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            return Convert.ToInt32(hexValue, 16);
        }
    }
}
