﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Samochod:Pojazd, IJazda
    {
        public void Jedz() //implementacja niejawna
        {
            Console.WriteLine("Jade samochodem");
        }
    }
}
