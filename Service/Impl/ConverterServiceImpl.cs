using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public decimal ConvertToDec(string hexValue)
        {
            return Convert.ToInt32(hexValue, 16);
        }

        public string ConvertToHex(string decValue)
        {
            return Convert.ToInt64(decValue).ToString("X");
        }
    }
}
