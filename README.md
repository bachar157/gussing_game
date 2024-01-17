# C# Word Guessing Game

This project is a simple console-based word guessing game implemented in C#. The game selects a random word from a predefined list, and the player must guess the word one letter at a time.

## Features

- **Word Database**: A collection of words from which the game randomly selects one for the player to guess.
- **Game Logic**: Manages the game flow, checks for correct or incorrect guesses, and keeps track of the player's progress.
- **User Interface**: Console-based interaction for guessing letters and viewing game progress.
- **String Manipulation**: Dynamic updating of the displayed word based on the player's correct guesses.
- **Error Handling**: Ensures that user input is valid (i.e., single letters).

## How to Run the Game

To run the game, you will need to have .NET installed on your system. If you don't have .NET installed, you can download it from [Microsoft's official .NET website](https://dotnet.microsoft.com/download).

### Steps to Run:

1. **Clone the Repository**: Clone this repository to your local machine or download the source code.
2. **Navigate to the Project**: Open a terminal and navigate to the project's root directory.
3. **Build the Project**: Run `dotnet build` to build the project.
4. **Run the Game**: Execute `dotnet run` from the root directory of the project to start the game.

## How to Play

- The game will display a series of underscores representing each letter of the word to be guessed.
- Input a single letter to make a guess.
- The game will update the displayed word with your correct guesses.
- You are allowed up to 6 incorrect guesses before the game ends.
- The game ends when you either guess the word correctly or run out of allowed incorrect guesses.

## Contributing

Feel free to fork this project and submit pull requests. You can also open an issue if you find any bugs or have suggestions for improvements.



