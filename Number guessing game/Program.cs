using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Choose your minimum number?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your maximum number?");
            int y = Convert.ToInt32(Console.ReadLine());
            int Gnumber = rand.Next(x,y);//We set the random number here
            Console.WriteLine("The game has started!");
            Console.WriteLine(Gnumber);
            Console.WriteLine("Enter your guess");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            bool gameIsRunning = true;

            do
            {
                if (userGuess == Gnumber)
                {
                    gameIsRunning = false;
                    Console.WriteLine("Yay!You did it you guessed right");
                }
                else if ( userGuess <= Gnumber + 10 && userGuess >= Gnumber-10)
                {
                    Console.Write("You are getting close.Try again: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());

                }
                else if (userGuess> Gnumber+10||userGuess<Gnumber-10)
                {
                    Console.Write("Your guess is not close.Try again: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    Console.Write("Wrong!Guess again: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }
            } while (gameIsRunning == true);
            
            
            Console.ReadKey();
        }
    }
}
