using System;

public class Program
{
    public static void Main()
    {
        // Declare and initialize variables of various data types
        int intValue = 10;
        float floatValue = 3.14f;
        string stringValue = "Hello, ";
        string name = "John";
        bool isTrue = true;
        bool isFalse = false;

        // Arithmetic operators
        int additionResult = intValue + 5;
        float subtractionResult = floatValue - 1.5f;
        int multiplicationResult = intValue * 3;
        float divisionResult = floatValue / 2;

        // Assignment operators
        int assignedValue = 20;
        assignedValue += 5; // equivalent to: assignedValue = assignedValue + 5;
        floatValue *= 2;   // equivalent to: floatValue = floatValue * 2;

        // Comparison operators
        bool isEqual = intValue == assignedValue;
        bool isNotEqual = intValue != assignedValue;
        bool isGreaterThan = intValue > assignedValue;
        bool isLessThan = intValue < assignedValue;

        // Logical operators
        bool andResult = isTrue && isFalse;
        bool orResult = isTrue || isFalse;
        bool notResult = !isTrue;

        // Output results
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition Result: {additionResult}");
        Console.WriteLine("Subtraction Result: {subtractionResult}");
        Console.WriteLine("Multiplication Result: {multiplicationResult}");
        Console.WriteLine("Division Result: {divisionResult}");

        Console.WriteLine("\nAssignment Operators:");
        Console.WriteLine("Assigned Value: {assignedValue}");
        Console.WriteLine("Float Value: {floatValue}");

        Console.WriteLine("\nComparison Operators:");
        Console.WriteLine("Is Equal: {isEqual}");
        Console.WriteLine("Is Not Equal: {isNotEqual}");
        Console.WriteLine("Is Greater Than: {isGreaterThan}");
        Console.WriteLine("Is Less Than: {isLessThan}");

        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("AND Result: {andResult}");
        Console.WriteLine("OR Result: {orResult}");
        Console.WriteLine("NOT Result: {notResult}");
    }
}