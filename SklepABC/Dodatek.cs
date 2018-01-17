using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepABC
{
    class Dodatek
    {
        internal static string[] dodatekTab= new string[6]{"dodatek1","dodatek2","dodatek3","dodatek4","dodatek5","dodatek6"};
            internal static string WzawracaDodatek(int a)
        {
            if(a>-1 && a< dodatekTab.Length)
            return Dodatek.dodatekTab[a];
                else
                    return "Blad";
            
        }
    }
}
