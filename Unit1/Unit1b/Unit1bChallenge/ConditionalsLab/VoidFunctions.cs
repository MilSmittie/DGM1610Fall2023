//I was a little confused by the requirments for this part of the challenge, but here is 
//the work I did while watching the videos. I'm unsure if this is necessary to turn in but
//It's pretty much the same, I just played around with the values a little.

using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(94, 54);
		myOperator.DoMath(2, 62);
		myOperator.DoMath(81, 11);
		myOperator.Compare(0,21);
		myOperator.Compare(3,9370);
		myOperator.CheckPassword("PlzBeCorrect1234%");
		myOperator.CheckPassword("OU812");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
}