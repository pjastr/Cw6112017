using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Osoba:IMuzyka, ISport
    {
        //public string Graj() //niejawna implementacja
        //{
        //    return "gra";
        //}

        string IMuzyka.Graj() //jawna implementacja
        {
            return "muzyka";
        }

        string ISport.Graj()
        {
            return "sport";
        }
    }
}
