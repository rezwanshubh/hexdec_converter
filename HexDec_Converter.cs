using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Service.Impl;

namespace HexDec_Converter
{
    class HexDec_Converter
    {
        static void Main(string[] args)
        {
            try
            {

                string[] seaparator = { " ", ",", ";", "\r\n", "\r", "\n" };

                Console.WriteLine("Please enter -i<file path> or values to convert");
                string myInput = Console.ReadLine();

                if (myInput.Trim().StartsWith("-i"))
                {
                    myInput = myInput.Replace("-i", "");
                    myInput = FileServiceImpl.InsFileData.ReadOutFile(myInput);
                }
                
                
                string[] inputNum = InputModifierServiceImpl.GetNumbers(myInput, seaparator);
                string finalOut = string.Empty;

                foreach (var vari in inputNum)
                {
                    if (vari.Length > 0)
                    {
                        string convertedResult = string.Empty;
                        if (vari.Trim().StartsWith("0x"))
                        {
                            convertedResult = ConverterServiceImpl.InsDataConverter.ConvertToDec(vari).ToString();
                        }
                        else
                        {
                            convertedResult = ConverterServiceImpl.InsDataConverter.ConvertToHex(vari).ToString();
                        }

                        if (finalOut != string.Empty)
                        {
                            finalOut = finalOut + "\r\n" + vari + " " + convertedResult;
                        }
                        else
                        {
                            finalOut = vari + " " + convertedResult;
                        }
                    }
                }

                Console.WriteLine("To save data in a file, please type -o<file path>. Otherwise simply press <Enter>");

                string consRead = Console.ReadLine();

                if (consRead.Trim().StartsWith("-o"))
                {
                    consRead = consRead.Replace("-o", "");

                    //WriteData.GetWriteData.WriteInFile_Async(finalOut, consRead);
                    FileServiceImpl.InsFileData.WriteInFileAsync(finalOut, consRead);
                    Console.WriteLine("Done asynchronously!");

                }
                else
                {
                    Console.WriteLine(finalOut);
                }

                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        
    }
}
