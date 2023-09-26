using System;

public class Program
{
    public void Main()
    {
        // Prompt the user for exam score.
        Console.WriteLine("Let's check your grade!");
        Console.WriteLine("Enter your exam score as a percentage:");

        // Convert user input to an integer.
        int grade = Convert.ToInt32(Console.ReadLine());
		
		// Display the grade message.
        string gradeMessage = Compare(grade);
		Console.WriteLine(gradeMessage);
       
		// Prompt the user for their favorite subject.
        Console.WriteLine("Enter your favorite subject:");
        string favoriteSubject = Console.ReadLine();
		
        // Display a message related to their favorite subject.
        switch (favoriteSubject.ToLower())
        {
            case "math":
                Console.WriteLine("Great choice! Keep practicing mathematical concepts!");
                break;
            case "science":
                Console.WriteLine("Science is amazing! Keep experimenting and hypothesizing!");
                break;
            case "history":
                Console.WriteLine("History is full of inspiring stories! Keep learning about the past!");
                break;
            case "english":
                Console.WriteLine("Reading and writing are essential! Keep working on them!");
                break;
            default:
                Console.WriteLine("That's an interesting subject! Keep learning!");
                break;
        }
    }

    // Determine the grade based on the exam score.
    public string Compare(int grade)
    {
        if (grade >= 90)
        {
            return "You got an A! Your hard work has paid off!";
        }
        else if (grade >= 80)
        {
            return "You got a B! Nice work!";
        }
        else if (grade >= 70)
        {
            return "You got a C... They say C's get degrees!";
        }
        else if (grade >= 60)
        {
            return "You got a D... Maybe listen in class next time..?";
        }
        else
        {
            return "You got an F... You're a lost cause.";
        }
    }
}