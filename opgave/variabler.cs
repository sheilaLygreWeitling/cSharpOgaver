using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    internal class variabler
    {
        public static void opg1()
        {
            var tal1 = 5; 
            var tal2 = 3;

            Console.WriteLine(tal1);
            Console.WriteLine(tal2);
        }
        public static void opg2()
        {
            var tal1 = 5;
            var tal2 = 3;

            Console.WriteLine("tal1 er " + tal1);
            Console.WriteLine("tal2 er " + tal2);
        }

        public static void opg3()
        {
            string name = "Søren";
            int alder = 16;
            double penge = 1234.34;

            Console.WriteLine("Jeg hedder " + name + ", er " + alder + " år gammel og har tjent " + penge + " på at alppe cykler" );
        }
        
        public static void opg4() {
            double kage = 23.56;
            double ol = 34.67; 
            double polse = 65.34;
            Console.WriteLine("Kage " + kage + "\nØl " + ol + "\nPølse " + polse + "\nI alt " + "\nBeregning"); 
        }

        public static void opg5() {
            var name = "Sheila";
            var alder = 30;
            Console.WriteLine("Jeg hedder " + name + " og er " + alder + " år gammel");
        }

        public static void opg6() { 
        
        }
    }
}
