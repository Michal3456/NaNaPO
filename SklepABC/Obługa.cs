using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SklepABC
{
    class Obługa
    {
        public static void ObslugaProgramu(int a)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("********************Witamy w sklepie ABC***********************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Menu:**********************************************************");
            Console.WriteLine("-->1:Tworznie samochodu o podanych przez urzytkowika prametach.");
            Console.WriteLine("-->2:Tworznie samochodu o gotowych parametrach.****************");
            Console.WriteLine("-->3:Wyjescie z programu.*********************************");
            if (a == 1)
            {

                //kk
            }
            else if (a == 2)
            {

            }
            else if(a == 3)
            {
                Environment.Exit(1);
            }
        }
    }
}
