using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-10;
            //kui genereeritud number on 5, programm lõpetab töö ja soovib kasutatale "Kena päeva!";
            //kui genereeritud number on muu, siis programm jätkab oma tööd.

            Random rnd = new Random();
            int i = 0; 

            while (i != 5) // tööta nii kaua, kui i pole 5
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if (myRandomNumber == 5) 
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
