using System;
					
public class Program
{
	public void Main()
	{
		//Prompted the user (temp advisor).
        Console.WriteLine("Temperature Adviser");
		Console.WriteLine("Enter the tempurature in Celcius:");
		
        //Converted user input to an integer in order to compare values (temp advisor).
        int value = Convert.ToInt32(Console.ReadLine());
		Check(value);
		
		//Prompted the user (exam grader).
		Console.WriteLine("Lets check your grade!");
		Console.WriteLine("Enter your exam score as a percentage:");

        //Converted user input to an integer in order to compare values (exam grader).
		int grade = Convert.ToInt32(Console.ReadLine());
		
        Compare(grade);
	}
	
	
    //Temp Advisor Operations
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

//Exam Grader Operations
public void Compare(int grade)
	{
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