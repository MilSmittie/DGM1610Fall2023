using System;
					
public class Program
{
	public void Main()
	{
        //Prompted the user.
		Console.WriteLine("Lets check your grade!");
		Console.WriteLine("Enter your exam score as a percentage:");

        //Converted user input to an integer in order to compare values.
		int grade = Convert.ToInt32(Console.ReadLine());
		
        Compare(grade);
	}
	
	public void Compare(int grade)
	{
        //Assigned a letter grade to the value the user inputed.
	if(grade >= 90)
        {
            Console.WriteLine("You got an A!!! Your hard work has paid off!!!");
        } 
        else if(grade >= 80)
        {
            Console.WriteLine("You got a B! Nice work!");
        }
        else if(grade >= 70)
        {
            Console.WriteLine("You got a C...! They say C's get degrees!");
        }
        else if(grade >= 60)
        {
            Console.WriteLine("You got a D... maybe listen in class next time..?");
        }
        else if(grade <= 60)
        {
            Console.WriteLine("You got an F... you're a lost cause.");
        }
	}
}