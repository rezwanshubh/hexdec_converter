using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Impl
{
    public class ConverterServiceImpl : IConverterService
    {
        private static ConverterServiceImpl _instance = null;

        public static ConverterServiceImpl InsDataConverter
        {
            get
            {
                if (_instance == null)
                    _instance = new ConverterServiceImpl();
                return _instance;
            }
        }

        public string ConvertToDec(string hexValue)
        {
            if (Regex.IsMatch(hexValue, @"0[xX][0-9a-fA-F]+"))
            {
                return Convert.ToInt32(hexValue, 16).ToString();
            }
            else
            {
                return "";
            }
        }

        public string ConvertToHex(string decValue)
        {
            if (Regex.IsMatch(decValue, @"[0-9]+(\.[0-9][0-9]?)?"))
            {
                return Convert.ToInt64(decValue).ToString("X");
            }
            else
            {
                return "";
            }
            
        }
    }
}
