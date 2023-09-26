using System;
					
public class Program
{
	public void Main()
	{
		//Prompted the user
        Console.WriteLine("Weather Adviser");
		Console.WriteLine("Enter the tempurature in Fahrenheit:");
		
        //Converted user input to an integer in order to compare values.
        int value = Convert.ToInt32(Console.ReadLine());
		Check(value);
	}
	
    //Operations
	public void Check(int value)
	{
        //Assigned a response to the value the user inputed.
		if(value > 130)
        {
            Console.WriteLine("You're a gonner. Say your prayers and greet the angels for me.");
        }
		 else if (value > 115)
        {
            Console.WriteLine("Holy crap where do you live? The Sun? Regardless, today's a perfect day to rock a birthday suit.");
        }
		 else if (value > 105)
        {
            Console.WriteLine("Its gonna be toasty so wear something breathable and light!");
        }
        else if (value > 75)
        {
            Console.WriteLine("Today's a perfect day! Put on whatever you please!");
        }
		 else if (value > 50)
        {
            Console.WriteLine("You might wanna wear a light jacket..");
        }
		 else if (value > 30)
        {
            Console.WriteLine("It's really too cold for that! Put on a warm coat!");
        }
		 else if (value > -30)
        {
            Console.WriteLine("You're gonna freeze to death if you walk outside like that. Put on at least another 10 layers!");
        }
		 else
        {
            Console.WriteLine("You're a gonner. Say your prayers and greet the angels for me.");
        }
	}
}