namespace Lab1;

using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Name:[Olivia Nolt]
        Title: [IT-1050 - Lab 1]
        */
        
        //Step 2
        Console.WriteLine("Name: [Olivia Nolt]");
        Console.WriteLine("Course Title: IT-1050 - Lab 1");

        //Step 3
        int favoriteNumber = 13;
        string favoriteLanguage = "Python";
        double programsWritten = 0;
        bool hasProgrammingExperience = false;

        Console.WriteLine("My favorite number is: " + favoriteNumber);
        Console.WriteLine("My favorite programming language is: " + favoriteLanguage);
        Console.WriteLine("The number of programs I've written before this is " + programsWritten);
        Console.WriteLine("Do I have programming experience? " + hasProgrammingExperience);

        //Step 4
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("My school name is:" + schoolName);

        //Step 5 
        double doubleValue = 9.78;
        int intFromDouble = (int)doubleValue; //Explicit casting
        Console.WriteLine("Original double: " + doubleValue);
        Console.WriteLine("Converted double to int (explicit cast): " + intFromDouble);

        int numberToInt = 123;
        string stringFromInt = Convert.ToString(numberToInt); // Using Convert class
        Console.WriteLine("Original int: " + numberToInt);
        Console.WriteLine("Converted int to string (Convert class): " + stringFromInt);

        bool boolValue = false;
        string stringFromBool = Convert.ToString(boolValue); // Using Convert class
        Console.WriteLine("Original bool:" + boolValue);
        Console.WriteLine("Converted bool to string (Convert class): " + stringFromBool);

        // Step 6
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Please enter your age: ");
        string ageInput = Console.ReadLine();
        int userAge = Convert.ToInt32(ageInput);

        Console.WriteLine("Hello," + userName + "! You are" + userAge + " years old.");
        
        // Step 7
        int num1 = 43;
        int num2 = 64;

        Console.WriteLine("num1: " + num1 + ", num2: " + num2);

        Console.WriteLine("Addition (num1 + 10):" + (num1 + 10));
        Console.WriteLine("Subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("Multiplication (num2 * 3): " + (num2 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num1 % 2):" + (num1 % 2));

        // Step 8
        float floatVar = 1.123456789f; // 'f' suffix for float
        double doubleVar = 1.123456789;

        Console.WriteLine("Float variable: " + floatVar);
        Console.WriteLine("Double variable: " + doubleVar);
        Console.WriteLine("Note: Double has higher precision than float, showing more decimal places accurately. ");

        // Step 9
        int value = 10;
        Console.WriteLine("Initial value: " + value);

        value++; // Increment
        Console.WriteLine("After increment: " + value);

        value--; // Decrement
        Console.WriteLine("After decrement: " + value);

    }
}
