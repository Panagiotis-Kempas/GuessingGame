using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am thinking of a number between 1 and 10.What is it?");

            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guess;
            int numberOfGuesses = 3;
            bool gameOver = false;
            






                while (gameOver == false)
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses--;

                    if (guess != randomNumber && numberOfGuesses == 0)
                    {
                        Console.WriteLine("You had 3 guesses and did not find the number.YOU LOSE!");
                        gameOver = true;
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("Thats it!YOU WIN!");
                        gameOver = true;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Nope!My number is smaller than that.");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("NO.My number is greater than that.");
                    }
                }

                
                
            }
        }
    }
}
