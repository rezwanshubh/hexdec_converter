using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDec_Converter
{
    class HexDec_Converter
    {
        static void Main(string[] args)
        {
            try
            {
                string[] seaparator = { " ",",", ";", "\r\n", "\r", "\n" };

                Console.WriteLine("Please enter -o<file path> or values to convert");
                string myInput = Console.ReadLine();

                if (myInput.Trim().StartsWith("-i"))
                {
                    myInput = myInput.Replace("-i", "");
                    myInput = ReadData.GetReadData.ReadFromFile(myInput);
                }
                else
                {
                    myInput = ReadData.GetReadData.ReadDirect(myInput);
                }

                //myInput = myInput.Replace(" ", "");
                string[] inputNum = ConverterData.GetNumbers(myInput, seaparator);
                string finalOut = string.Empty;

                foreach (var vari in inputNum)
                {
                    if (vari.Length > 0)
                    {
                        string convertedResult = string.Empty;
                        if (vari.Trim().StartsWith("0x"))
                        {
                            convertedResult = ConverterData.ConvertToDec(vari).ToString();
                        }
                        else
                        {
                            convertedResult = ConverterData.ConvertToHex(vari).ToString();
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
                    Console.WriteLine(WriteData.GetWriteData.WriteInFile(finalOut, consRead));
                }
                else
                {
                    Console.WriteLine(finalOut);
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
