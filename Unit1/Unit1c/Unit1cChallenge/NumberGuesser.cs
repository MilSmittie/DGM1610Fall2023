using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11);
        int attempts = 1;
        int guess;

        Console.WriteLine("I'm thinking of a number between 1 and 10. Try to guess it!");
		
        do
        {
			Console.WriteLine();
			Console.Write("Enter your guess: ");
			
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;
				
                if (guess < secretNumber)
                {
					Console.WriteLine();
					Console.WriteLine("It's too low! Guess again!");
                }
                else if (guess > secretNumber)
                {
					Console.WriteLine();
					Console.WriteLine("It's too high! Guess again!");
                }
                else
                {
					Console.WriteLine();
					Console.WriteLine("Congratulations! You guessed the number " + secretNumber + " in " + attempts + " attempt(s).");
                }
            }
            else
            {
                Console.WriteLine();
				Console.WriteLine("Invalid input. Please enter a valid number between 1 and 10.");
            }
        } 
		
		while (guess != secretNumber);

        Console.WriteLine();
		Console.WriteLine("Thanks for playing!");
    }
}