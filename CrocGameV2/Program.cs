// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
using CrocGameV2;

Console.WriteLine("Hello, in this game you will have to type the character that corresponds " +
                  "with the 2 random numbers.");
Console.WriteLine("For example with 3_5 the correct symbol will be '<");
Console.WriteLine("Remember to only type the symbols '<' '>' '='!");

bool gameOn = true;

int points = 0;

while (gameOn == true)
{
    int rng1 = rng();
    int rng2 = rng();
    Console.WriteLine($"{rng1}_{rng2}");
    char userAnswer = Convert.ToChar(Console.ReadLine());
    if (userAnswer == correctAnswer(rng1, rng2))
    {
        points++;
        Console.WriteLine($"Correct answer! +1 points");
        Console.WriteLine($"Your points: {points}");
    }
    else if (userAnswer != '<' || userAnswer != '=' || userAnswer != '>')
    {
        Console.WriteLine("You have entered a forbidden key! The program will now stop!");
        gameOn = false;
    }
    else
    {
        points--;
        Console.WriteLine($"Wrong answer! -1 points");
        Console.WriteLine($"Your points: {points}");
    }

   

    if (points == 10)
    {
        Console.WriteLine("Congratulations! You have won the game, here is your virtual pat on the back!");
        gameOn = false;
    }
}
char correctAnswer(int rng1, int rng2)
{
    char answer = '.';
    if (rng1 < rng2)
    {
        answer = '<';
    }
    else if (rng1 > rng2)
    {
        answer = '>';
    }
    else if(rng1 == rng2)
    {
        answer = '=';
    }

    return answer;
}
int rng()
{
    Random rand = new Random();
    int number1 = rand.Next(1, 12);
    return number1;
}
