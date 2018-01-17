using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SklepABC
{
    class WyborWypozaczenia
    {
        internal const string Lajt = "Light";
        internal const string Medi = "Medium";
        internal const string Prem = "Premium";

        internal static string WyborWyposazenia(int a)
        {
            switch (a)
            {
                case 1:
                    {
                        return WyborWypozaczenia.Lajt;                      
                    }
                case 2:
                    {
                        return WyborWypozaczenia.Medi;                        
                    }
                case 3:
                    {
                        return WyborWypozaczenia.Prem;       
                    }
                default:
                    return "Blad";
            }
        }
    }
}
