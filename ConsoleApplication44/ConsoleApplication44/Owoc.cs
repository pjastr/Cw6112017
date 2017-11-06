using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Owoc:IJedzenie
    {
        public void Jedzenie()
        {
            Console.WriteLine("owoc");
        }

        void IJedzenie.Jedzenie()
        {
            Console.WriteLine("owoc - jawna");
        }
    }
}
