using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		
		//hero's health and powerlevel levels
		heroOne.health = 1;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;

		heroThree.health = 2;
		heroThree.powerLevel = 4;
		
		//changing statistics
		heroOne.health --;
		heroOne.powerLevel --;
        heroTwo.powerLevel ++;
		heroTwo.health ++;
		heroThree.health --;
		heroThree.powerLevel ++;
		
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
		if (heroThree.health <= 0)
		{
			Console.WriteLine("Dani Devito lives another day!");
		}
		else
		{
			Console.WriteLine("YOU KILLED DANI DEVITO.");
		}
		
		//writing out hero's health and power amounts
		Console.WriteLine(heroOne.heroOneName + "'s health is " + heroOne.health);
		Console.WriteLine(heroOne.heroOneName + "'s power level is " + heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.heroTwoName + "'s health is " + heroTwo.health);
		Console.WriteLine(heroTwo.heroTwoName + "'s power level is " + heroTwo.powerLevel);

		Console.WriteLine(heroThree.heroThreeName + "'s health is " + heroThree.health);
		Console.WriteLine(heroThree.heroThreeName + "'s power level is " + heroThree.powerLevel);
	}
}

//declaring variables
public class Hero {
	public int health;
	public int powerLevel;
	public string heroOneName = "John Cena";
	public string heroTwoName = "Lebron James";
	public string heroThreeName = "Dani Devito";
}