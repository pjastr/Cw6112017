﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Samochod:Pojazd, IJazda
    {
        public void Jedz()
        {
            Console.WriteLine("Jadę samochodem");
        }
    }
}
