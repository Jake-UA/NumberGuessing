using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            GetInfo();

            string decision = "Y";
            int guess, correctNumber;

            while(true) {
                guess = 0;
                Random randomNumber = new Random();
                correctNumber = randomNumber.Next(1, 10);

                while(guess != correctNumber) {
                    Console.WriteLine("\n" + "Guess a number from 1 to 10");
                    string inputGuess = Console.ReadLine();

                    if(!int.TryParse(inputGuess, out guess)) {
                        Console.WriteLine("Enter an actual number");
                        continue;
                    }

                    guess = Int32.Parse(inputGuess);
                    if (guess != correctNumber) {
                        PrintConsoleColor(ConsoleColor.Red, "\n" + "Wrong number. Please try again!");
                    }

                    if (guess == correctNumber) {
                        PrintConsoleColor(ConsoleColor.Magenta, "\n" + "YOU ARE CORRECT: " + guess + "\n");
                    }
                } //end inner while

                while (decision != "Y" || decision != "N") {
                    Console.Write("Play again? [Y/N]: ");
                    decision = Console.ReadLine().ToUpper();

                    if (decision == "Y") {
                        Console.Write("\n" + "Starting over!");
                        break;
                    }
                    else if (decision == "N") {
                        PrintConsoleColor(ConsoleColor.Yellow, "Goodbye! :)" + "\n");
                        return;
                    }
                    else {
                        PrintConsoleColor(ConsoleColor.Red, "\n" + "Please enter a valid answer!" + "\n");
                    }
                }//end inner while

            } //end outer while

        } //end main

        //Methods
        static void GetInfo() {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appDeveloper = "Jake Williams";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appDeveloper);
            Console.ResetColor();
        }

        static void GreetUser() {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}, let's play a game", input);
        }

        static void PrintConsoleColor(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    } //end class
} //end namespace
