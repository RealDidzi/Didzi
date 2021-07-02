using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1,101);

            Console.WriteLine("Välkommen till gissa talet spelet!");
            Console.WriteLine("Jag tänker på ett tal mellan 1 till 100, kan du gissa rätt?");
            Console.WriteLine("Gissar du rätt så vinner du!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Välj ett tal eller siffra: ");
                int guess = Convert.ToInt32(Console.ReadLine()); //Convert to int

                if(guess > randomNum)
                {
                    Console.WriteLine("Du gissade för högt! Försök igen");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("Du gissade för lågt! Försök igen");
                }
                else
                {
                    Console.WriteLine("Du gissade rätt! Fantastiskt!");
                    isCorrectGuess = true;
                }    
                     

            }

            Console.WriteLine("Grattis, Du lyckades slå mig!");
            
            Console.ReadKey();
        }   
    }
}