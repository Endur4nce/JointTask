﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class ConsoleLogger : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
