﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Gruszka:Owoc, IJedzenie
    {
        public void Jedzenie()
        {
            Console.WriteLine("gruszka");
        }
    }
}
