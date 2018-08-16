using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static int GetGuess()
        {
            int result = 0;

            Console.WriteLine("Please guess the number");
            String answer = Console.ReadLine();
            Int32.TryParse(answer, out result);
            return result;
        }

        static void Main(string[] args)
        {
            const int ourNumber = 10;
            int guessNumber = 0;

            for (int n = 20; n > 0; n--) {
                guessNumber = GetGuess();
                switch(guessNumber)
                {
                    case (ourNumber):
                        Console.WriteLine("Correct! Well Done!");
                        n = 0;
                        break;
                    case (1):
                        Console.WriteLine("You enter the number 1, but that was WAAAY to low! You only have {0} guesses left.", n - 1);
                        break;
                    case (20):
                        Console.WriteLine("You entered the number 20 which is a bit to high! You only have {0} guesses left.", n - 1);
                        break;
                    case (100):
                        Console.WriteLine("You entered the number 100 which is WAAAY to high! You only have {0} guesses left.", n - 1);
                        break;
                    default:
                        if (guessNumber > ourNumber)
                        {
                            Console.WriteLine("Oops - sorry, you were too high! You only have {0} guesses left.", n - 1);
                        }
                        else
                        {
                            Console.WriteLine("Oops - sorry, you were too low! You only have {0} guesses left.", n - 1);
                        }
                        break;
                }
                //if (guessNumber == ourNumber)
                //{
                //    Console.WriteLine("Correct! Well Done!");
                //    break;
                //}
                //else if (guessNumber > ourNumber)
                //{
                //    Console.WriteLine("Oops - sorry, you were too high! You only have {0} guesses left.", n-1);
                //}
                //else
                //{
                //    Console.WriteLine("Oops - sorry, you were too low! You only have {0} guesses left.", n - 1 );
                //}
            }

            //while(ourNumber != guessNumber)
            //{
            //    guessNumber = GetGuess();
            //    if (guessNumber == ourNumber)
            //    {
            //        Console.WriteLine("Correct! Well Done!");
            //    }
            //    else if (guessNumber > ourNumber)
            //    {
            //        Console.WriteLine("Oops - sorry, you were too high!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Oops - sorry, you were too low!");
            //    }
            //}

            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }
    }
}
