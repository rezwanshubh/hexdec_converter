﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IConverterService
    {
        string ConvertToHex(string decValue);
        string ConvertToDec(string hexValue);
    } 
}
