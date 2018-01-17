using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepABC
{
    class Samochod
    {
        static string[] model = new string[2]{ "ABC", "ABC1" };
        string modelmodel;
        string modelNowy;
        string dodatek;
        string wyposazenie;
        private Samochod(int modelI,string wyposazenie)
        {
            this.modelmodel = Samochod.model[modelI];
            this.wyposazenie = wyposazenie;
        }
        private Samochod(string wyposazenie)
        {
            this.wyposazenie = wyposazenie;
        }
        private Samochod(string modelNowy, string wyposazenie, string dodatek)
        {
            this.modelNowy = modelNowy;
            this.wyposazenie = wyposazenie;
            this.dodatek = dodatek;
        }
        public static Samochod ZwrocSamochodAutoTworzenie(int model, int wyposazenie)
        {
            string wyposazenieString = "Blad";
            if (Samochod.model[model] == Samochod.model[0]||Samochod.model[1]==Samochod.model[model])
            {
                    Console.WriteLine("NIe ma takiego modelu. Jesli chcesz stworzyc model, wpisz dodatek do samochodu.");
            }
            if (wyposazenie > 3 || wyposazenie < 1)
                Console.WriteLine("NIe ma takiego wyposazniea, jesli chcesz stworzyc, dodaj dodatek.");
            else
                wyposazenieString = WyborWypozaczenia.WyborWyposazenia(wyposazenie);
          
                Samochod samochod = new Samochod(model,wyposazenieString);
            return samochod;
        }
        public static Samochod ZwrocSamochodSamoTworzenie(string model, string wyposazenie, int dodatek)
        {
            string dodatekString = Dodatek.WzawracaDodatek(dodatek);
            Samochod samochod = new Samochod(model, wyposazenie, dodatekString);
            return samochod;
        }
        public string ZwroacaInfo()
        {
            return "Model:" + this.modelmodel + "Wyposazenie:" + this.wyposazenie + "Dodatek:" + this.dodatek;
        }
        
    }
}
