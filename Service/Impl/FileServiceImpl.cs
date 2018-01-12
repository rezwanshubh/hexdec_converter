using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impl
{
   public class FileServiceImpl : IFileService
    {
        private static FileServiceImpl _instance = null;

        public static FileServiceImpl InsFileData
        {
            get
            {
                if (_instance == null)
                    _instance = new FileServiceImpl();
                return _instance;
            }
        }

        public string ReadOutFile(string path)
        {
            return File.ReadAllText(path);
        }

        public string WriteInFile(string values, string filePath)
        {
            File.WriteAllText(filePath, values);
            return "done";
        }

        public async Task WriteInFileAsync(string values, string filePath)
        {
            UnicodeEncoding uniencoding = new UnicodeEncoding();

            byte[] result = uniencoding.GetBytes(values);

            using (FileStream SourceStream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                SourceStream.Seek(0, SeekOrigin.End);
                await SourceStream.WriteAsync(result, 0, result.Length);
            }
            //throw new NotImplementedException();

        }
    }
}
