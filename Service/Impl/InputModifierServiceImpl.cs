using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
    public static class InputModifierServiceImpl 
    {
        public static string[] GetNumbers(string fullString, string[] separator)
        {
            return fullString.Split(separator, StringSplitOptions.None);
        }
    }
}
