using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutsajal sisestada tema limmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", kuvab konsool "oled loodusesõber";
            //kui kasutaja sisestab midagi muud, kuvab konsool "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv");
            string userColor = Console.ReadLine();
            if(userColor == "punane") 
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(userColor == "sinine") 
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline") 
            {
                Console.WriteLine("Oled loodusesõber");
            }
            else 
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
