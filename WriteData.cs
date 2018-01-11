using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec_Converter
{
    class WriteData : IOutput
    {
        private static WriteData instance = null;

        public static WriteData GetWriteData
        {
            get
            {
                if (instance == null)
                    instance = new WriteData();
                return instance;
            }
        }

        public string WriteDirect(string values)
        {
            return "done";
        }

        public string WriteInFile(string values, string filePath)
        {
            File.WriteAllText(filePath, values);

            return "done";
        }
    }
}
