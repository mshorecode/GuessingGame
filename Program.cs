﻿string greeting = "\n\t\tWelcome to Guessing Game!\n\tYou have 4 guesses to get the secret number!";
bool userGuess;
int numericValue;
Random random = new Random();
int secretNumber = random.Next(1, 101);

Console.WriteLine(greeting);

for (int i = 3; i >= 0; i--)
{

    do
    {
        Console.WriteLine($"\nGuess the secret number (You have {i} guesses left):");
        userGuess = int.TryParse(Console.ReadLine(), out numericValue);
        Console.WriteLine(secretNumber);
    }
    while (!userGuess);

    if (numericValue == secretNumber)
    {
        Console.WriteLine("\nCongrats! You guessed the secret number!");
        break;
    }
    else
    {
        Console.WriteLine("\nSorry that's not the secret number. Try Again");
    }
}