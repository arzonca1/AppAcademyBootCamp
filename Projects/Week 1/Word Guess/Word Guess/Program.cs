using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Word_Guess
{
    class Program
    {
        /// <summary>
        /// The main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Word Guess Game");
            List<string> phrases = GetPhrases();
            PlayGame(phrases);


        }


        /// <summary>
        /// Function which reads all lines from provided file and loads them into a list of strings, one string per line. 
        /// </summary>
        /// <returns> List of strings, one per line</returns>
        static List<string> GetPhrases()
        {
            return File.ReadAllLines(Directory.GetCurrentDirectory() + @"\..\..\Word list.txt").ToList();
        }

        /// <summary>
        /// Function which actually handles the game. 
        /// </summary>
        /// <param name="phrases">List of strings to be guessed in the game </param>
        static void PlayGame(List<string> phrases)
        {

            string phrase = SelectPhrase(phrases);
            char[] phraseCharacters = GetPhraseCharacters(phrase);
            List<Char> phraseDistinctCharacter = GetPhraseDistinctCharacters(phraseCharacters);
            List<Char> characterGuesses = new List<Char>();
            const int MaxGuesses = 5;
            int wrong_guesses = 0;
            DisplayPhrase(phraseCharacters, characterGuesses);
            while (wrong_guesses < MaxGuesses)
            {
                Console.WriteLine($"\n\nYou have {MaxGuesses - wrong_guesses} tries left.");

                char input = GetCharacterGuess(characterGuesses);
                characterGuesses.Add(input);
                if (phraseDistinctCharacter.Contains(input))
                {
                    Console.WriteLine($"\nYou guessed {input} correctly!");
                }
                else
                {
                    Console.WriteLine("\nYou guessed incorrectly...");
                    wrong_guesses++;
                }
                if (!DisplayPhrase(phraseCharacters, characterGuesses).Contains('#'))
                {
                    Console.WriteLine("You guessed the phrase correctly, you win.");
                    Console.ReadKey();
                    return;

                }
            }
            Console.WriteLine("You ran out of tries, you lose");
            Console.WriteLine(phrase);
            Console.ReadKey(); 
            return;

        }
        /// <summary>
        /// Function which randomly selects one of the strings provided for use in game. 
        /// </summary>
        /// <param name="phrases">List of strings to choose from</param>
        /// <returns>One string from the provided list</returns>
        static string SelectPhrase(List<string> phrases)
        {
            return phrases.ElementAt(new Random().Next(0, phrases.Count - 1));
        }

        /// <summary>
        /// Turns string into an array of characters and changes every lowercase character to uppercase for ease of comparison later.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Uppercase char array</returns>
        static char[] GetPhraseCharacters(string str)
        {
            return str.ToUpper().ToCharArray();
        }


        /// <summary>
        /// Takes a char array and creates a list where each character is represented once. 
        /// </summary>
        /// <param name="phraseCharacters">Char array</param>
        /// <returns>List where each character item is unique</returns>
        static List<char> GetPhraseDistinctCharacters(char[] phraseCharacters)
        {
            List<char> phraseDistinctCharacters = new List<char>();
            foreach (char letter in phraseCharacters)
            {
                if (letter >= 'A' && letter <= 'Z' && !phraseDistinctCharacters.Contains(letter)) phraseDistinctCharacters.Add(letter);
            }
            return phraseDistinctCharacters;
        }

        /// <summary>
        /// Prints the phrase with every unguessed character obscured as '#'. Also returns a list represenation of the output. Used for testing victory condition (no #s). 
        /// </summary>
        /// <param name="phraseCharacters">Char array containing the full phrase</param>
        /// <param name="guessedCharacters">Char list of characters that were previously guessed. </param>
        /// <returns>List representation of the printed output</returns>
        static List<char> DisplayPhrase(char[] phraseCharacters, List<char> guessedCharacters)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char a in phraseCharacters)
            {
                if (a < 'A' || a > 'Z') sb.Append(a); // non alphabetic character (e.g. append it) 
                if (a >= 'A' && a <= 'Z')
                {
                    if (guessedCharacters.Contains(a)) sb.Append(a);
                    else sb.Append('#');
                }
            }
            string str = sb.ToString();
            Console.WriteLine(str);
            return str.ToList();

        }

        /// <summary>
        /// Prompts player for a letter guess. Will retry if the guess was already made or is invalid (not a letter). 
        /// </summary>
        /// <param name="playerGuesses">List containing all prior guesses. </param>
        /// <returns>Player's selected letter. </returns>
        static char GetCharacterGuess(List<char> playerGuesses)
        {
            char input = '\0';
            Console.WriteLine("Guess a letter (A-Z):");
            while (true)
            {
                input = char.ToUpper(Console.ReadKey().KeyChar);
                if (input >= 'A' && input <= 'Z' && !playerGuesses.Contains(input))
                {
                    return input;
                }
                else if (input >= 'A' && input <= 'Z' && playerGuesses.Contains(input))
                {
                    Console.WriteLine("You already guessed that letter, try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid input (A-Z only)");
                    continue;
                }
            }

        }


    }
}




