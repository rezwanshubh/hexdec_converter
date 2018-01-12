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
            throw new NotImplementedException();
        }

        public async Task WriteInFile_Async(string values, string filePath)
        {
            UnicodeEncoding uniencoding = new UnicodeEncoding();

            byte[] result = uniencoding.GetBytes(values);

            using (FileStream SourceStream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                SourceStream.Seek(0, SeekOrigin.End);
                await SourceStream.WriteAsync(result, 0, result.Length);
            }

            Console.WriteLine("done");
        }
    }
}
