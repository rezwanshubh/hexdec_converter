using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface IFileService
    {
        string ReadOutFile(string path);
        string WriteInFile(string values, string filePath);
        Task WriteInFileAsync(string values, string filePath);
    }
}
