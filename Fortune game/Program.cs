using System;

Random r = new Random();
int x = r.Next(0 ,100);
bool GuessedCorrectly = false;
Console.WriteLine("Welcome to Guess the number Game (0-100) with in 5 attempts.");
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Enter your {i} number:");
    int newnumber = Convert.ToInt32(Console.ReadLine());
    if (newnumber == x)
    {
        Console.WriteLine($"Entered number is Correct");
        Console.WriteLine("YOU WIN THE GAME ");
        GuessedCorrectly = true;
        break;
    }
    else if (newnumber >= x)
    {
        Console.WriteLine($"Entered number is greater than original number ");
        GuessedCorrectly = false;
    }
    else if (newnumber <= x)
    {
        Console.WriteLine($"Entered number is less than original number");
        GuessedCorrectly = false;
    }
    }
if (GuessedCorrectly == false)
{
    Console.WriteLine("Unfortunately you did not guess it correctly. The correct number is: " + x);
}


