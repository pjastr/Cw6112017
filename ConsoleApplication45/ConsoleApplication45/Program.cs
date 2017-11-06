using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class WlasnaKlasa:IBbb
        {

            public string Wyraz()
            {
                return "sss";
            }

            public int Liczba()
            {
                return 56;
            }
        }

        interface IAaa
        {
            int Liczba();
        }

        interface IBbb:IAaa
        {
            string Wyraz();
        }
    }
}
