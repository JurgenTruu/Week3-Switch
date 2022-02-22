using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine() .ToLower();
            
            switch (userColor) 
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
