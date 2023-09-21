using System;

public class Program
{
    public static void Main()
    {
        //Randomizing number program picks
        Random random = new Random();
        int secretNumber = random.Next(1, 11);
        
        //Delclaring variables
        int attempts = 1;
        int guess;

        //Displaying instructions
        Console.WriteLine("I'm thinking of a number between 1 and 10. Try to guess it!");
		
        //Code to compare user's number to the number the computer picked
        do
        {
			Console.WriteLine();
			Console.Write("Enter your guess: ");
			
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;
				
                if (guess < secretNumber)
                {
					//If they guessed too low
                    Console.WriteLine();
					Console.WriteLine("It's too low! Guess again!");
                }
                else if (guess > secretNumber)
                {
					//If they guessed too high
                    Console.WriteLine();
					Console.WriteLine("It's too high! Guess again!");
                }
                else
                {
					//If they got it right it displays the programs number and the amount of attempts it took to guess it
                    Console.WriteLine();
					Console.WriteLine("Congratulations! You guessed the number " + secretNumber + " in " + attempts + " attempt(s).");
                }
            }
            else
            {
                //in case they enter something other than a number between 1 and 10
                Console.WriteLine();
				Console.WriteLine("Invalid input. Please enter a valid number between 1 and 10.");
            }
        } 
		
		while (guess != secretNumber);

        //Ending the game
        Console.WriteLine();
		Console.WriteLine("Thanks for playing!");
    }
}