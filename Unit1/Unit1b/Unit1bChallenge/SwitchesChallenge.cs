using System;
					
public class Program
{
	public PowerUps powerUps;
	
	public void Main()
	{
		//State of power displayed
		powerUps = new PowerUps();
		powerUps.currentState = PowerUps.Power.Ready;
		powerUps.CheckPowerUp();
		
		//Prompt user to use power
		Console.WriteLine("Enter the amount of power to use as a percentage:");
		int value = Convert.ToInt32(Console.ReadLine());
		Compare(value);
	}
public void Compare(int value)
{
	if(value > 100)
	{
		Console.WriteLine("It's impossible to use that much power!");
	}
	else if (value == 100)
	{
		Console.WriteLine("Initiating full power!");
	}
	else
	{
		Console.WriteLine("Initiating " + value + "% power!");
	}
}
}

public class PowerUps 
{
	public enum Power 
    {
		NotReady,
		InUse,
		Ready,
		Initiated
	}
	
	public Power currentState = Power.NotReady;
	
	public void CheckPowerUp() 
    {
		switch (currentState) {
			case Power.NotReady:
				Console.WriteLine("Power is not fully charged yet.");
				break;
			case Power.InUse:
				Console.WriteLine("Be quick! Power is draining fast!");
				break;
			case Power.Ready:
				Console.WriteLine("All charged up!");
				break;
			case Power.Initiated:
				Console.WriteLine("Turning on the power!");
				break;
		}
	}
}