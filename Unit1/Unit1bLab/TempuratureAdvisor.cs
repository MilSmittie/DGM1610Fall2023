using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Temperature Adviser");
		Console.WriteLine("Enter the tempurature in Celcius:");
		int value = Convert.ToInt32(Console.ReadLine());
		Check(value);
	}
	
	public void Check(int value)
	{
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