using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec_Converter
{
    class ReadData : IInput
    {
        private static ReadData _instance = null;

        public static ReadData GetReadData
        {
            get
            {
                if (_instance == null)
                    _instance = new ReadData();
                return _instance;
            }
        }

        public string ReadDirect(string values)
        {
            return values;
        }

        public string ReadFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
