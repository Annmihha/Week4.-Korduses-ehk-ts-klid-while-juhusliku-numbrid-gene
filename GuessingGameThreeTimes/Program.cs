using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 - 10;
            //kasutaja peab seda numbit ära arvama;
            //kui kasutaja arvas numbri ära, siis on ta võitja;
            //kasutajal on kolm katset, kui kasutaja ei suuda kolme katsega ära arvata, siis
            //mängu võidab arvuti;
            //programm genereerib juhuslikku numbrit vaid 1 kord.

            
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

                int i = 0;

                Console.WriteLine("Tere tulemast mängima!");

                while (i < 3)
                {
                    Console.WriteLine("Palun sisesta oma number 1-10.");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    if (userNumber == cpuNumber)
                    {
                        Console.WriteLine($"Palju õnne! Oled võitja! Võidunumber oligi {cpuNumber}.");
                        break;
                    }
                    else if (i != 2)
                    {
                        i = i + 1;
                        Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                    }
                    else
                    {
                    Console.WriteLine("Ikka vale number. MINU võit.");
                    break;
                    }
                 }
            Console.WriteLine("Kena päeva!");
            }
         }
    }
