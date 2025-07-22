namespace Lab3;

using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple For Loop
        Console.WriteLine("--- Problem 1: Simple For Loop ---");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    
        Console.WriteLine(); // Blank line for readability


        // --- Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator) ---
        Console.WriteLine("--- Problem 2: Even Numbers from 1 to 20 ---");
        // This loop iterates from 1 to 20
        // An if statement with the modulus operator (i % 2 == 0) checks if the number is even.
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();


        // --- Problem 3: While Loop Countdown ---
        Console.WriteLine("--- Problem 3: While Loop Countdown ---");
        int countdown = 5;
        // The loop continues as long as 'countdown' is greater than or equal to 1.
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--; // Decrement the counter in each iteration.
        }
        Console.WriteLine();


        // --- Problem 4: While Loop - Multiples of 10 from 10 to 1000 ---
        Console.WriteLine("--- Problem 4: While Loop - Multiples of 10 ---");
        int multiple = 10;
        // This loop continues as long as 'multiple' is less than or equal to 1000.
        while (multiple <= 1000)
        {
            Console.WriteLine(multiple);
            multiple += 10; // Increment by 10 to get the next multiple of 10.
        }
        Console.WriteLine();


        // --- Problem 5: Seasons of the Year ---
        Console.WriteLine("--- Problem 5: Seasons of the Year ---");
        // Declare and initialize a string array named 'seasons'.
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        // A foreach loop iterates through each element in 'seasons' array.
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        Console.WriteLine();


        // --- Problem 6: Days of the Week (1-7) ---
        Console.WriteLine("--- {Problem 6: Days of the Week ---");
        // Create an array named 'days' with 7 strings for days of the week.
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number from 1 to 7 to display the corresponding day: ");
        string userInput = Console.ReadLine();
        int dayNumber;

        // Use int.TryParse for robust input handling.
        if (int.TryParse(userInput, out dayNumber))
        {
            // Check if the entered number is within the valid range (1 to 7).
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                // Arrays are 0-indexed, so subtract 1 from the user's input to get the correct index.
                Console.WriteLine($"Day: {days[dayNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter a number between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine(" Invalid input: Please enter a valid number.");
        }
        Console.WriteLine();


        // --- Problem 7: Favorite Books and Authors ---
        Console.WriteLine("--- Problem 7: Favorite Books and Authors ---");
        // Create two string arrays for book titles and their corresponding authors. 
        string[] bookTitles = { "Harry Potter", "Perks of Being a Wallflower", "The Cellar" };
        string[] authors = { "J.K Rowling", "Stephen Chbosky", "Natasha Preston" };

        // Use a for loop to iterate through both array simultaneously using their index.
        for (int i = 0; i < bookTitles.Length; i++)
        {
            Console.WriteLine($"{bookTitles[i]} by {authors[i]}");
        }
        Console.WriteLine();


        // --- Problem 8: Temperature Tracker ---
        Console.WriteLine("--- Problem 8: Temperature Tracker ---");
        // Create an integer array with 5 temperature values.
        int[] temperatures = { 77, 79, 84, 89, 84 };

        Console.WriteLine("Original Temperatures: " + string.Join(",", temperatures));

        // Use Array.Sort() to sort the array in ascending order/
        Array.Sort(temperatures);
        Console.WriteLine("Temperatures in Ascending Order: " + string.Join(",", temperatures));

        //After sorting, the lowest temperature is the first element, and the highest is the last.
        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");
        Console.WriteLine($"Highest Temperature: {temperatures[temperatures.Length - 1]}");

        Console.WriteLine();

        // ---Problem 9: Reverse Countdown ---
        Console.WriteLine("--- Problem 9: Reverse Countdown ---");
        // Declare an integar array with intial values.
        int[] reverseArray = { 5, 4, 3, 2, 1 };

        Console.WriteLine("Original Array: " + string.Join(",", reverseArray));

        // Use Array.Reverse() to reverse order of elements in the array.
        Array.Reverse(reverseArray);
        Console.WriteLine("Array After Reversing: " + string.Join(",", reverseArray));

        // Use a for loop to display the new order.
        Console.WriteLine("Displaying Reversed Array with For Loop");
        for (int i = 0; i < reverseArray.Length; i++)
        {
            Console.WriteLine(reverseArray[i]);
        }
        Console.WriteLine();
    }
}