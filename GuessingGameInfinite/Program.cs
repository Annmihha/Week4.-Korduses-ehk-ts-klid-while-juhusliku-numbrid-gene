using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 - 10;
            //kasutaja peab seda numbit ära arvama;
            //kui kasutaja arvas numbri ära, siis on ta võitja;
            //katsete aerv on piiramatu;
            //programm genereerib juhuslikku numbrit vaid 1 kord.
            
            Console.WriteLine("Tere tulemast mängima!");

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            
                               
           while(true)         
            {
                Console.WriteLine("Palun sisesta oma number 1-10.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                 
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine($"Palju õnne! Oled võitja! Võidunumber oligi {cpuNumber}.");
                    break;
                }
                else
                {
                   Console.WriteLine("Proovi veel!");
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
