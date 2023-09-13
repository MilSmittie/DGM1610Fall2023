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
		string result = (value > 30) ? "Stay hydrated and avoid staying in the sun for too long!" : "Enjoy the pleasant weather!";
		Console.WriteLine(result);
	}
}