using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    internal class variablerUdtryk
    {
        public static void opg1()
        {
            int times3 = 3; 
            int times4 = 4;
            int times5 = 5;
            int result;
            result = times3 * times4 * times5;
            Console.WriteLine(result);
        }

        public static void opg2()
        {
            double puk = 65;
            double damsgaard = 25.8;
            double piratPizza = 7;
            double result;
            result = damsgaard * puk + 13 % piratPizza - 4;
            Console.WriteLine(result);
        }
    }
}
