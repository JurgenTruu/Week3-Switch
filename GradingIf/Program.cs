using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai;
            //kui kasutaja sai "a", konsool kuvab "suurepärane";
            //B, konsool kuvab väga hea;
            //C, konsool kuvab hea;
            //D, konsool kuvab rahuldav;
            //E, konsool, kuvab kasin;
            //F, konsool kuvab puudulik;

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine() . ToUpper());
            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");

            }
            else if (userResult == 'B') 
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine($"Vale väärtus!");
            }



        }
    }
}
