/*
*todo: Display a message to the user asking them to guess the secret number.
*todo: Display a prompt for the user's guess.
*todo: Take the user's guess as input and save it as a variable.
todo: Display the user's guess back to the screen.
*/

using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! Guess that secret number, n3rd.");
            Console.Write("What's your guess? input it here:");
            Console.ReadLine();
            int UserAnswer = Console.ReadLine();

            Console.Write(UserAnswer);
        }
    }
}

