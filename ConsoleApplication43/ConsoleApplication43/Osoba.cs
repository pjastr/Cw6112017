using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Osoba: ISport, IMuzyka
    {
        //public string Graj() //niejawna implemntacja
        //{
        //    return "gra";
        //}

        string IMuzyka.Graj()  //jawna implementacja
        {
            return "muzyka";
        }

        string ISport.Graj()
        {
            return "sport";
        }
    }
}
