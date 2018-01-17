using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepABC
{
    class WypowylanieTworzenieGotowegoSam
    {
        public static string TworznieGotSam()
        {
            Console.WriteLine("Podaj model(Uwaga liczby odpowadaja wyrazom): dostepnie <0>ABC i <1>ABC1");
            int model = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wyposazenie(Uwaga liczby odpowadaja wyrazom): dostepne: <0>Light, <1>Medium, <2>Premium.");
            int wyposazenie = Int32.Parse(Console.ReadLine());
            Samochod samochod =Samochod.ZwrocSamochodAutoTworzenie(model, wyposazenie);
            return samochod.ZwroacaInfo();
        }
    }
}
