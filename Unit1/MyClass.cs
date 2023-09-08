// This program I created doesn't do a ton. All it can do right now is write down-
// the statistics for each character, but I would love to work to make this more interactive! 

using System;

public class Program
{ 
	public Rapper rapperOne;
	public Rapper rapperTwo;
	
	public void Main()
	{
		rapperOne = new Rapper();
		rapperTwo = new Rapper();
		
		Console.WriteLine("ROUND 1: LIL PATTY VS LIL SPONGE");
		Console.WriteLine();
		
		//Lil Patty's statistics
		rapperOne.swagger = 100;
		rapperOne.flow = 72;
		rapperOne.crowdControl = 8;
		rapperOne.roast = 203;
		
		//Lil Sponge's statistics
		rapperTwo.swagger = 75;
		rapperTwo.flow = 65;
		rapperTwo.crowdControl = 6;
		rapperTwo.roast = 97;
		
		//Writing Lil Patty's statistics
		
		Console.WriteLine("Lil Patty's swag is at " + rapperOne.swagger + " percent");
		Console.WriteLine("Lil Patty is flowin at a rate of " + rapperOne.flow + "mph");
		Console.WriteLine("Lil Patty has the croud roarin at a solid " + rapperOne.crowdControl + " out of 10");
		Console.WriteLine("Lil Patty's roasts are a whoppin " + rapperOne.roast + " degrees");
		Console.WriteLine();
		
		//Writing Lil Sponge's statistics
		
		Console.WriteLine("Lil Sponge's swag is at " + rapperTwo.swagger + " percent");
		Console.WriteLine("Lil Sponge is flowin at a rate of " + rapperTwo.flow + "mph");
		Console.WriteLine("Lil Sponge has the croud roarin at a solid " + rapperTwo.crowdControl + " out of 10");
		Console.WriteLine("Lil Sponge's roasts are a whoppin " + rapperTwo.roast + " degrees");
		Console.WriteLine();
		
		
	}
}

public class Rapper
{
	public string rapperOneName = "Lil Patty";
	public string rapperTwoName = "Lil Sponge";
	public int swagger;
	public int roast;
	public int flow;
	public int crowdControl;
}