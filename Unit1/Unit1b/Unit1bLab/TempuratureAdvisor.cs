using System;
					
public class Program
{
	public void Main()
	{
		//Prompted the user
        Console.WriteLine("Temperature Adviser");
		Console.WriteLine("Enter the tempurature in Celcius:");
		
        //Converted user input to an integer in order to compare values.
        int value = Convert.ToInt32(Console.ReadLine());
		Check(value);
	}
	
    //Operations
	public void Check(int value)
	{
        //Assigned a response to the value the user inputed.
		if(value > 30)
        {
            Console.WriteLine("Stay hydrated and avoid staying in the sun for too long!");
        }
        else 
        {
            Console.WriteLine("Enjoy the pleasant weather!");
        }
	}
}