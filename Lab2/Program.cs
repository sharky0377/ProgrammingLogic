namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Operator Practice
        Console.WriteLine("--- Part 1: Operator Practice ---");

        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine($"a: {a}, b: {b}, c: {c}");

        // Check if a is greater than b
        Console.WriteLine($"a > b: {a > b}");

        // Check if a is less than c
        Console.WriteLine($"a < c: {a < c}");

        // Check if a is greater than both b and c (using &&)
        Console.WriteLine($"a > b && a > c: {a > b && a > c}");

        // Check if a is greater than b OR a is greater than c (using ||)
        Console.WriteLine($"a > b || a > c: {a > b || a > c}");

        Console.WriteLine(); // Blank line for readability



        // Part 2: Boolean Logic
        Console.WriteLine("---Part 2: Boolean Logic---");

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");

        }

        Console.WriteLine(); // Blank line for readability


        // Part 3: Conditional Logic - Movie Ticket Pricing
        Console.WriteLine("---Part 3: Conditional Logic - Movie Ticket Pricing ---");

        Console.Write("Please enter your age: ");
        string ageInput = Console.ReadLine();

        int age;
        // Using int.TryParse to convert input safely
        if (int.TryParse(ageInput, out age))
        {
            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else // age is 65 or older
            {
                Console.WriteLine("Senior ticket: $6");
            }
        }
        else
        {
            Console.WriteLine("Invalid age entered. Please enter a whole number.");

            Console.WriteLine(); // Blank line for readability


            // Part 4: Using a switch Statement
            Console.WriteLine("--- Part 4: Using a switch Statement ---");

            Console.Write("Enter a day of the week (1-7): ");
            string dayInput = Console.ReadLine();
            int dayNumber = Convert.ToInt32(dayInput); // Converts user input to integer

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

            Console.WriteLine(); // Blank line for readability
        }

    }

}


       
