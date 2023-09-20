using System;
					
public class Program
{
	public void Main()
	{  
		//Obtaining user input and converting it into an integer
		Console.WriteLine("Enter a positive integer:");
		int rows = Convert.ToInt32(Console.ReadLine());
		
		//Nested loops
		  for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
		
			  //Just to have a seperation in the lines
			  Console.WriteLine();
		}
	}
}