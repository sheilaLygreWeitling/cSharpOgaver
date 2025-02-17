using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave
{
    internal class elseIfStatements
    {
        public static void opg1()
        {
            int tal1 = 42;
            int tal2 = 20;
            var result = tal1 + tal2;
            if (result > 100)
            {
                Console.WriteLine("Summen er større end 100!");
            }
            else if (result < 100)
            {
                Console.WriteLine("Summen er mindre end 100.");
            }
            else
            {
                Console.WriteLine("Summen er 100!");
            }
        }
        public static void opg2()
        {
            var alder = 0;
            Console.WriteLine("Indtast alder:\n");
            alder = int.Parse(Console.ReadLine());
            if (alder > 57)
            {
                Console.WriteLine("Du er for gammel");
            }
            else if (alder < 57)
            {
                Console.WriteLine("Du er ikke for gammmel");
            }
        }
        public static void opg3()
        {
            var alder = 0;
            Console.WriteLine("Indtast din alder:\n");
            alder = int.Parse(Console.ReadLine());
            if (alder > 60)
            {
                Console.WriteLine("Du er for gammel.");
            }
            else if (alder >= 50 && alder <= 60)
            {
                Console.WriteLine("Du er hverken for ung eller for gammel.");
            }
            else if (alder < 50)
            {
                Console.WriteLine("Du er for ung");
            }
        }
        public static void opg4og5()
        {
            string navn = "Puk Damsgaard";
            string brugernavn = "damsgaardPuk";
            string brugernavnBrugerInput = " ";
            string password = "123456789o";
            string passwordBrugerInput = " ";
            bool brugernavnKorrekt = true;
            Console.WriteLine("Skriv brugernavn:\n");
            brugernavnBrugerInput = Console.ReadLine();
            if (brugernavn != brugernavnBrugerInput)
            {
                brugernavnKorrekt = false;
                Console.WriteLine("Brugernavn er forkert");
            }
            if (brugernavnKorrekt)
            {
                Console.WriteLine("Skriv password:\n");
                passwordBrugerInput = Console.ReadLine();
                if (password != passwordBrugerInput)
                {
                    Console.WriteLine("Password er forkert");
                } else
                {
                    Console.WriteLine("Velkommen " + navn);
                }
            }
        }
         public static void opg6() {
            double km = 0;
            Console.WriteLine("Angiv kilometer du kører hver dag:\n");
            km = double.Parse(Console.ReadLine());
            if (km <= 24)
            {
                Console.WriteLine("Du får ingenting, muhahaha");
            } else if (km >= 24 || km <= 120)
            {
                Console.WriteLine("Dit fradrag er " + ((km - 24 )* 1.93) + " kr");
            } else 
            {
                Console.WriteLine("Dit fradrag er: " + (96 * 1.93 +(km - 120) *0.97));
            }
        }
        public static void opg7()
        {
            Console.Title = "Festen";

            Console.WriteLine("Hvilken farve kan du bedst lide?\n 1. Rød \n 2. Grøn\n 3. Blå\n 4. Gul");
            int colorNum;  
            colorNum = int.Parse(Console.ReadLine());

            if (colorNum == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("fedt mand, Rød");
                Console.ResetColor();
            }
            if (colorNum == 2)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("GRØØØØØØN LÅLÅLÅ");
                Console.ResetColor();
            }
            if(colorNum == 3)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blå som en himmel");
                Console.ResetColor();
            }
            if (colorNum == 4)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Gul og du kan lide smør");
                Console.ResetColor();
            }

            Console.WriteLine("Hvad er din alder?\n");
            int alder; 
            alder = int.Parse(Console.ReadLine());
            if (alder >= 18)
            {
                Console.WriteLine("Velkommen til cocktailbaren <3");
            }
            else if (alder <= 18)
            {
                Console.WriteLine("Ah ah ah, you didn't say the magic word! (Velkommen til sodavandsbaren)");
            }
        }
    } 
}
