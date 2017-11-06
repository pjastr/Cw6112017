using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Rower:Pojazd, IJazda, IMuzyka
    {
        public void Jedz()
        {
            Console.WriteLine("jade rowerem");
        }

        public void Klakson()
        {
            Console.WriteLine("dryń");
        }
    }

}
