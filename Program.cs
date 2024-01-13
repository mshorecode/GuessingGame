using System.Threading.Channels;

string greeting = "\n\t\tWelcome to Guessing Game!\n\tYou have 4 guesses to get the secret number!";
bool userGuess;
bool difficultyChoice;
int numericValue = 0;
int choiceNumber = 0;
Random random = new();
int secretNumber = random.Next(1, 101);
string[] difficulty = ["Easy", "Medium", "Hard", "Cheater"];

Console.WriteLine(greeting);

do
{
    Console.WriteLine("\nPlease choose a difficulty level:");
          
    for (int i = 0; i < difficulty.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {difficulty[i]}");
    }

    difficultyChoice = int.TryParse(Console.ReadLine(), out choiceNumber);
}
while(!difficultyChoice || choiceNumber < 0 || choiceNumber > difficulty.Length);


switch (choiceNumber)
{
    case 1:
        Easy();
        break;

    case 2:
        Medium();
        break;

    case 3:
        Hard();
        break;

    case 4:
        Cheater();
        break;
}


void Easy()
{
    for (int i = 7; i >= 0; i--)
    {
        do
        {
            Console.WriteLine($"\n[EASY] Guess the secret number (You have {i} guesses left):");
            userGuess = int.TryParse(Console.ReadLine(), out numericValue);
        }
        while (!userGuess || numericValue < 0 || numericValue >= 100);

        if (numericValue == secretNumber)
        {
            Console.WriteLine("\nCongrats! You guessed the secret number!");
            break;
        }
        else if (numericValue < secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is lower than the secret number. Try Again");
        }
        else if (numericValue > secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is higher than the secret number. Try Again");
        }
    }
}

void Medium()
{
    for (int i = 5; i >= 0; i--)
    {
        do
        {
            Console.WriteLine($"\n[MEDIUM] Guess the secret number (You have {i} guesses left):");
            userGuess = int.TryParse(Console.ReadLine(), out numericValue);
        }
        while (!userGuess);

        if (numericValue == secretNumber)
        {
            Console.WriteLine("\nCongrats! You guessed the secret number!");
            break;
        }
        else if (numericValue < secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is lower than the secret number. Try Again");
        }
        else if (numericValue > secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is higher than the secret number. Try Again");
        }
    }
}

void Hard()
{
    for (int i = 3; i >= 0; i--)
    {
        do
        {
            Console.WriteLine($"\n[HARD] Guess the secret number (You have {i} guesses left):");
            userGuess = int.TryParse(Console.ReadLine(), out numericValue);
        }
        while (!userGuess);

        if (numericValue == secretNumber)
        {
            Console.WriteLine("\nCongrats! You guessed the secret number!");
            break;
        }
        else if (numericValue < secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is lower than the secret number. Try Again");
        }
        else if (numericValue > secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is higher than the secret number. Try Again");
        }
    }
}

void Cheater()
{
    do
    {
        Console.WriteLine($"\n[CHEATER] Guess the secret number (You have unlimited guesses):");
        userGuess = int.TryParse(Console.ReadLine(), out numericValue);

        if (numericValue == secretNumber)
        {
            Console.WriteLine("\nCongrats! You guessed the secret number!");
            break;
        }
        else if (numericValue < secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is lower than the secret number. Try Again");
        }
        else if (numericValue > secretNumber)
        {
            Console.WriteLine("\nSorry that's not the secret number.\nYour guess is higher than the secret number. Try Again");
        }
    }
    while (!userGuess || numericValue != secretNumber);    
}