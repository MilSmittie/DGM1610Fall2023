using System;

public class Program
{
    public static void Main()
    {
        //Creating string
        string[] favoriteFoods = new string[3];

        Console.WriteLine("Please enter your three favorite foods:");

        for (int i = 0; i < 3; i++)
        {
            //User Input
            Console.Write("Favorite food " + (i + 1) + ": ");
            favoriteFoods[i] = Console.ReadLine();
        }


        Console.WriteLine("Here are your favorite foods:");

        foreach (string food in favoriteFoods)
        {
           //Displaying user's food coices with comment.
            Console.WriteLine(food + "! Good choice!");
        }
    }
}