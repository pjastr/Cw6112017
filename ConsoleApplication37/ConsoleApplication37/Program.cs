﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod();
            samochod1.Jedz();

            Rower rower1 = new Rower();
            rower1.Jedz();
            rower1.Klakson();

            Console.ReadKey();
        }
    }
}
