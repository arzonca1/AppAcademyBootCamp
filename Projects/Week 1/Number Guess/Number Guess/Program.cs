using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guess
{

    class OutOfRangeException : Exception { }
    class Program
    {

        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] playerName = new string[2];
            Console.WriteLine("Welcome to Number Guess Game");
            playerName[0] = GetPlayerName(0);
            playerName[1] = GetPlayerName(1);
            PlayGame(playerName[0], playerName[1]);

        }


        /// <summary>
        /// Asks for and returns player's name as a string.
        /// </summary>
        /// <param name="i">Player's number</param>
        /// <returns>Player's name as a string</returns>
        static string GetPlayerName(int i)
        {
            string name = string.Empty;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine($"Player {i + 1}, please enter your name:");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) Console.WriteLine("Invalid name.");
            }
            return name;

        }

        /// <summary>
        /// Asks player for a number between 1-100, parses it into int and returns. 
        /// </summary>
        /// <param name="playername">Player's name as a string</param>
        /// <param name="message">Specific message to request the number from the player</param>
        /// <returns></returns>
        static int GetNumber(string playername, string message)
        {
            int result = 0;
            const int MinValue = 1, MaxValue = 100; // constant declarations 
            while (true)
            {
                Console.WriteLine($"{playername}, {message}");
                try
                {
                    result = int.Parse(Console.ReadLine());
                    if (result < MinValue || result > MaxValue) throw new OutOfRangeException();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number, please retry.");
                    continue;
                }
                break;
            }
            return result;
        }


        /// <summary>
        /// Ran at end of the game. Asks if the players want to switch and go again, accepts Y/N button presses, ignores all others. . 
        /// </summary>
        /// <returns>Boolean value, true if Y is pressed, false is N is pressed. Other inputs ignored. </returns>
        static bool GetYNAnswer()
        {
            while (true)
            {
                char response = Console.ReadKey().KeyChar;
                if (response == 'y' || response == 'Y') return true;
                if (response == 'n' || response == 'N') return false;
            }
        }


        /// <summary>
        /// Function that handles the actual execution of the game. 
        /// </summary>
        /// <param name="playerName">Array containing the player names</param>
        static void PlayGame(string player1Name, string player2Name)
        {


            while (true)
            {
                int secretNumber = GetNumber(player1Name, $"please enter the number for {player2Name} to guess:");
                bool guessedCorrectly = false;

                Console.Clear();
                Console.WriteLine($"{player1Name}'s number accepted.\n{player2Name}, good luck.");
                for (int triesRemaining = 10; triesRemaining > 0; triesRemaining--)
                {
                    int guess = GetNumber(player2Name, $"You have {triesRemaining} tries remaining:");
                    if (guess == secretNumber)
                    {
                        guessedCorrectly = true;
                        break;
                    }
                    if (guess < secretNumber) Console.WriteLine("Too low.");
                    if (guess > secretNumber) Console.WriteLine("Too high.");
                }
                if (guessedCorrectly) Console.WriteLine($"{player2Name} guessed correctly and won.");
                else Console.WriteLine($"{player2Name} ran out of tries, {player1Name} wins.");

                Console.WriteLine("Switch players and play again? (Y/N)");

                if (GetYNAnswer())
                {
                    string temp = player1Name;
                    player1Name = player2Name;
                    player2Name = temp;
                    Console.Clear();
                }
                else break;
            }


        }
    }
}
