using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaladoMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev = "";
            int szulev = 0;
            bool ffi = true;
            double magassag = 1.7803;
           int aktualisPont = 0;
            do
            {
                bool select = false;
                do
                {
                    ShowMenu(aktualisPont);
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            select = true;
                            break;
                        case ConsoleKey.UpArrow:
                            if (aktualisPont > 0)
                            {
                                aktualisPont--;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (aktualisPont < 2)
                            {
                                aktualisPont++;
                            }
                            break;
                        default:
                            Console.Beep();
                            break;
                    }

                }
                while (!select);
                switch (aktualisPont)
                {
                    case 0: //Adatbekérés
                        InputData(out nev, out szulev, out ffi, out magassag);
                        break;
                    case 1: //adatkiírás
                        Console.Clear();
                        Console.WriteLine("***Adat Kiírás***");
                        Console.WriteLine($"Neve {nev}");
                        Console.WriteLine($"Születési éve: {szulev}");
                        Console.WriteLine($"Magassága {magassag:F2}m");
                        if (ffi)
                        {
                            Console.WriteLine("Neme: Férfi");
                        }
                        else
                        {
                            Console.WriteLine("Neme: Nő");
                        }
                        Console.WriteLine("Enterrel tovább...");
                        Console.ReadLine();
                            break;
                    case 2: //kilépés
                        Console.Clear();
                        Console.Write("Biztosan kilépsz? (i/n)");
                        if (Console.ReadKey().Key != ConsoleKey.I)
                        {
                            aktualisPont = 0;
                        }
                        break;

                        
                }
            }
            while (aktualisPont != 2);
        }

        private static void InputData(out string nev, out int szulev, out bool ffi, out double magassag)
        {
            Console.Clear();
            Console.WriteLine("***Adat bekérés***");
            Console.WriteLine("Adja meg a nevét:");
            nev = Console.ReadLine();
            Console.WriteLine("Adja meg születési dátumát:");
            szulev = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a nemét (f/n):");
            ffi = Console.ReadLine() == "f";
            Console.WriteLine("Adja meg magasságát:");
            magassag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adatait rögzítettük. Enterrel tovább...");
        }

        static void ShowMenu(int cPoint)
        {
            Console.Clear();
            if (cPoint == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("1 - Személyes adatok bekérése:");
            if (cPoint == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("2 - Személyes adatok kiírása");
            if (cPoint == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("3 - Kilépés");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
