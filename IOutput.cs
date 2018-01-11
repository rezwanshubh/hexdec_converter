using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec_Converter
{
    interface IOutput
    {
        string WriteDirect(string values);
        string WriteInFile(string values, string filePath);
    }
}
