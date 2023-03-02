using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("What is the magic number? ");
        Console.WriteLine($"The number is {number}. ");
        Console.WriteLine("What is your guess? ");
        string userInput = Console.ReadLine();
        int response = int.Parse(userInput);

        while (response != number)
        {
            if (number < response)
            {
                Console.WriteLine("Go lower.");
                Console.WriteLine("Enter your new guess: ");
                response = int.Parse(userInput);
                userInput = Console.ReadLine();
            }
                else
            {
                Console.WriteLine("Go higher.");
                Console.WriteLine("Enter your new guess: ");
                userInput = Console.ReadLine();
                response = int.Parse(userInput);
            }
        }
        Console.WriteLine("You guess it!");
    }
}