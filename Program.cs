using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Even and Odd Number Checker ===");

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                CheckEvenOdd(number);

                // OPTIONAL: Save to database
                // SaveToDatabase(number);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            Console.Write("Do you want to try again? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "y")
            {
                continueProgram = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

    static void CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is EVEN.");
        }
        else
        {
            Console.WriteLine($"{number} is ODD.");
        }
    }

    // DATABASE METHOD (we'll connect later)
    static void SaveToDatabase(int number)
    {
        Console.WriteLine("Saved to database (placeholder)");
    }
}