using System;
using algoLesson.Recursion;

class Program
{
    static void Main(string[] args)
    {
        /**********************Find Factoril****************/

        Console.Write("Enter a number to find its factorial: ");

        // Get input from the user
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            long result = Factorial.FindFactorial(number);
            Console.WriteLine($"Factorial of {number} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        /**********************End of Find Factoril****************/

    }
}
