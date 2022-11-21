/*
& phase 1
*todo: Display a message to the user asking them to guess the secret number.
*todo: Display a prompt for the user's guess.
*todo: Take the user's guess as input and save it as a variable.
*todo: Display the user's guess back to the screen.
^note: console.readline will pause the function! 

& phase 2 
*todo: Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
*todo: No longer display the user's guess. They know what they guessed, right?
*todo: Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
*/

using System;

//& phase1
// namespace GuessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello user! Guess that secret number, n3rd.");
//             Console.Write("What's your guess? input it here:");
//             // Console.ReadLine();
//             string UserAnswer = Console.ReadLine();

//             Console.Write(UserAnswer);
//             // Console.ReadLine();
//         }
//     }
// }






namespace GuessingGame
//&Phase 2
{
    class Program
    {
        static void Main(string[] args)
        {
            int SuperSecretInt = 42;
            Console.WriteLine("Hello user! Guess that secret number, n3rd.");
            Console.Write("What's your guess? input it here:");
            string UserAnswer = Console.ReadLine();

            if (int.Parse(UserAnswer) == SuperSecretInt)
            {
                Console.WriteLine($"Wowzers! {UserAnswer} is correct!");
            }
            else
            {
                Console.WriteLine("nahhh that's wrong. Try again?");
            }
        }
    }
}