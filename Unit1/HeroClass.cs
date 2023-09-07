using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		//hero's health and powerlevel levels
		heroOne.health = 1;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		
		//changing statistics
		heroOne.health --;
		heroOne.powerLevel --;
        heroTwo.powerLevel ++;
		heroTwo.health ++;
		
		//if hero dies itll say
		if (heroOne.health <= 0) 
		{
			Console.WriteLine("John Cena lives another day!");
		} 
		else 
		{
			Console.WriteLine("YOU KILLED JOHN CENA.");
		}
		
		if (heroTwo.health <= 0) 
		{
			Console.WriteLine("Lebron James lives another day!");
		} 
		else 
		{
			Console.WriteLine("YOU KILLED LEBRON JAMES.");
		}
		
		//writing out hero's health and power amounts
		Console.WriteLine(heroOne.heroOneName + "'s health is " + heroOne.health);
		Console.WriteLine(heroOne.heroOneName + "'s power level is " + heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.heroTwoName + "'s health is " + heroTwo.health);
		Console.WriteLine(heroTwo.heroTwoName + "'s power level is " + heroTwo.powerLevel);
	}
}

//declaring variables
public class Hero {
	public int health;
	public int powerLevel;
	public string heroOneName = "John Cena";
	public string heroTwoName = "Lebron James";
}