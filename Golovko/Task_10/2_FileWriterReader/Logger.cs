﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FileWriterReader
{
    static class Logger
    {
        public static void Write(string message)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("{0} => {1}", currentDate, message);
        }
    }
}