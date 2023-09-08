// This program I created doesn't do a ton. All it can do right now is determine a winner-
// only based on "swagger percentage". In the future, I would love to work to make this- 
// more interactive and have the other variables play a role in who wins.

using System;

public class Program
{ 
	public Rapper rapperOne;
	public Rapper rapperTwo;
	
	public void Main()
	{
		rapperOne = new Rapper();
		rapperTwo = new Rapper();
		
		//User Input Code
		Console.WriteLine("ROUND 1: LIL PATTY VS LIL SPONGE");
		Console.WriteLine();
		Console.WriteLine("Enter Lil Patty's swagger percentage:");
		int rapperOneswagger = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Lil Sponge's swagger percentage:");
		int rapperTwoswagger = Convert.ToInt32(Console.ReadLine());
		
		//Storing Lil Patty's statistics;
		rapperOne.flow = 72;
		rapperOne.crowdControl = 8;
		rapperOne.roast = 203;
		
		//Storing Lil Sponge's statistics
		rapperTwo.swagger = 75;
		rapperTwo.flow = 65;
		rapperTwo.crowdControl = 6;
		rapperTwo.roast = 97;
		
		//Displaying Lil Patty's statistics
		
		Console.WriteLine();
		Console.WriteLine("Lil Patty's swag is at " + rapperOneswagger + " percent");
		Console.WriteLine("Lil Patty is flowin at a rate of " + rapperOne.flow + "mph");
		Console.WriteLine("Lil Patty has the croud roarin at a solid " + rapperOne.crowdControl + " out of 10");
		Console.WriteLine("Lil Patty's roasts are a whoppin " + rapperOne.roast + " degrees");
		Console.WriteLine();
		
		//Displaying Lil Sponge's statistics
		
		Console.WriteLine("Lil Sponge's swag is at " + rapperTwoswagger + " percent");
		Console.WriteLine("Lil Sponge is flowin at a rate of " + rapperTwo.flow + "mph");
		Console.WriteLine("Lil Sponge has the croud roarin at a solid " + rapperTwo.crowdControl + " out of 10");
		Console.WriteLine("Lil Sponge's roasts are a whoppin " + rapperTwo.roast + " degrees");
		Console.WriteLine();
		
		//Determining the winner through Boolean
		if (rapperOneswagger > rapperTwoswagger)
		{
			Console.WriteLine("LIL PATTY WINS!!!");
		}
		else if (rapperTwoswagger > rapperOneswagger)
		{
			Console.WriteLine("LIL SPONGE WINS!!!");
		}
		else
			
		{
			Console.WriteLine("It's a tie!");
		}
		
	}
}

//Storing Rapper class variables
public class Rapper
{
	public string rapperOneName = "Lil Patty";
	public string rapperTwoName = "Lil Sponge";
	public int swagger;
	public int roast;
	public int flow;
	public int crowdControl;
}