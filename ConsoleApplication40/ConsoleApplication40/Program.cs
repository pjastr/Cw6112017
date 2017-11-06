using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class WlasnaKlasa:IBbb
    {

        public string Wyraz()
        {
            return "ssds";
        }

        public int Liczba()
        {
            return 3;
        }
    }

    interface IAaa
    {
        int Liczba();
    }

    interface IBbb : IAaa
    {
        string Wyraz();
    }
}
