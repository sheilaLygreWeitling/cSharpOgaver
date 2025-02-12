using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    internal class strings
    {
        public static void opg1()
        {
            int catBorn = 2022;
            string catName = "Dagmar";
            double catAge = 3.5;
            Console.WriteLine("Min kat " + catName + " er fra " + catBorn + " og er " + catAge + " år gammel <3");
        }
        public static void opg2()
        {
            int catBorn = 2022;
            string catName = "Dagmar";
            double catAge = 3.5;
            catBorn = 3022;
            catName = "Miavmar";
            catAge = 1000.5;
            Console.WriteLine("Min kat " + catName + " er fra " + catBorn + " og er " + catAge + " år gammel <3");
        }
        public static void opg3()
        {
            string jul = "I dag har vi den 24. Decemeber";
            Console.WriteLine(jul);
        }
        public static void opg4()
        {
            double penge = 200.50;
            string jegHar = "Jeg har ";
            string iBanken = " kr. i banken";
            Console.WriteLine(jegHar + penge + iBanken);
        }
    }
}
