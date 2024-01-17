using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gussing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the word database and select a random word for the game
            WordDatabase db = new WordDatabase();
            string wordToGuess = db.GetRandomWord();

            // Create and start the game with the chosen word
            GameManager gameManager = new GameManager(wordToGuess);
            Console.WriteLine("Welcome to the Word Guessing Game!");
            gameManager.PlayGame();

            // Pause the program for 5 seconds before exiting, allowing the user to see the final game state
            Thread.Sleep(5000);

        }
    }
}
