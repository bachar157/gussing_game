using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class GameManager
    {
         string secretWord; // The word the player is trying to guess
         string displayWord; // Representation of the word with guessed letters and underscores
         int incorrectGuesses; // Count of incorrect guesses made by the player
         int MaxGuesses = 6; // Maximum allowed incorrect guesses

        // Constructor initializes the game with the secret word
        public GameManager(string word)
        {
            secretWord = word;
            displayWord = new string('_', word.Length); // Initialize displayWord with underscores
            incorrectGuesses = 0; // Reset incorrect guesses count
        }

        // Main method to start and control the game flow
        public void PlayGame()
        {
            while (incorrectGuesses < MaxGuesses && displayWord.Contains("_"))
            {
                DisplayWord(); 
                string guessedLetter = GetUserGuess(); 
                ProcessGuess(guessedLetter);
            }
            EndGame(); // Handle the game ending
        }

        // Displays the current state of the guessing word to the player
        public void DisplayWord()
        {
            Console.WriteLine("\nCurrent word: " + displayWord);
        }

        // Prompts the user to guess a letter and validates the input
        public string GetUserGuess()
        {
            Console.Write("Guess a letter: ");
            string input = Console.ReadLine();
            try
            {
                if (input.Length != 1 || !Char.IsLetter(input[0]))
                    throw new ArgumentException("Please enter a single letter."); // Ensure input is a single letter
                return input.ToLower(); // Convert to lowercase for consistency
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetUserGuess(); // Recursive call for a new attempt
            }
        }

        // Updates the game state based on the player's guess
        public void ProcessGuess(string guessedLetter)
        {
            if (secretWord.Contains(guessedLetter))
            {
                // Update displayWord if the guess is correct
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i].ToString() == guessedLetter)
                    {
                        displayWord = displayWord.Remove(i, 1).Insert(i, guessedLetter);
                    }
                }
            }
            else
            {
                incorrectGuesses++; // Increment incorrect guesses count
                Console.WriteLine("Incorrect guess. Try again.");
            }
        }

        // Handles the end of the game and displays appropriate messages
        public void EndGame()
        {
            if (incorrectGuesses >= MaxGuesses)
            {
                Console.WriteLine("Game Over! The word was: " + secretWord); // Player failed to guess the word
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the word: " + secretWord); // Player guessed the word
            }
        }
    }
}