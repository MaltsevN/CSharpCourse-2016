﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    static class Log
    {
        public static void Write(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
