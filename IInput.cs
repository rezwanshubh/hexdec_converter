using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec_Converter
{
    interface IInput
    {
        string ReadDirect(string values);
        string ReadFromFile(string path);
    }
}
