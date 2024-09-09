﻿using System;
using algoLesson.Iteration;
using algoLesson.Recursion;

class Program
{
    static void Main(string[] args)
    {
        /**********************Find Factoril****************/

        Console.Write("Enter a number to find its factorial using Recursion: ");

        // Get input from the user
        string inputFacRec = Console.ReadLine();

        if (int.TryParse(inputFacRec, out int number))
        {
            long result = Factorial.FindFactorial(number);
            Console.WriteLine($"Factorial of {number} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        /**********************End of Find Factoril****************/

        /**********************Find Factoril using iteration****************/
        Console.Write("Enter a number to find its factorial using Iteration: ");

        // Get input from the user
        string inputFacIter = Console.ReadLine();

        if (int.TryParse(inputFacIter, out int number1))
        {
            long result = Factorial_Iteration.FindFactorialUsingIteration(number1);
            Console.WriteLine($"Factorial of {number1} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        /**********************End of Find Factoril using iteration****************/

        /********************** Find Fibonacci using Recursion****************/
        Console.Write("Enter a number to find its Fibonacci using Recursion: ");

        // Get input from the user
        string inputFibRec = Console.ReadLine();

        if (int.TryParse(inputFibRec, out int number2))
        {
            long result = Fibonacci.FindFibonacci(number2);
            Console.WriteLine($"Fibonacci of {number2} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        /********************** End of Find Fibonacci using Recursion****************/


        /********************** Find Fibonacci using Recursion****************/
        Console.Write("Enter a number to find its Fibonacci using Iteration: ");

        // Get input from the user
        string inputFibIter = Console.ReadLine();

        if (int.TryParse(inputFibIter, out int number3))
        {
            long result = Fibonacci_Iteration.FindFibonacciUsingIteration(number3);
            Console.WriteLine($"Fibonacci of {number3} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        /********************** End of Find Fibonacci using Iteration****************/


        /**********************  Find GCD using Recursion****************/
        Console.Write("Enter a number1 to find its GCD using Recursion: ");
        // Get input from the user
        string GCDNum1 = Console.ReadLine();

        Console.Write("Enter a number2 to find its GCD using Recursion: ");
        // Get input from the user
        string GCDNum2 = Console.ReadLine();

        if (int.TryParse(GCDNum1, out int numberGCD1) && int.TryParse(GCDNum2, out int numberGCD2))
        {
            long result = GCD_Recursion.findGCDUsingRecursion(numberGCD1, numberGCD2);
            Console.WriteLine($"GCD of {numberGCD1} and {numberGCD2} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numbers.");
        }
        /********************** End of Find GCD using Recursion****************/


        /**********************  Find GCD using Iteration****************/
        Console.Write("Enter a number1 to find its GCD using Iteration: ");
        // Get input from the user
        string GCDNum3 = Console.ReadLine();

        Console.Write("Enter a number2 to find its GCD using Iteration: ");
        // Get input from the user
        string GCDNum4 = Console.ReadLine();

        if (int.TryParse(GCDNum3, out int numberGCD3) && int.TryParse(GCDNum4, out int numberGCD4))
        {
            long result = GCD_Iteration.FindGCDUsingIteration(numberGCD3, numberGCD4);
            Console.WriteLine($"GCD of {numberGCD3} and {numberGCD4} is: {result}");
        }
        else
        {
            Console.WriteLine("Invalid inputs. Please enter a valid numbers.");
        }
        /**********************End of Find GCD using Iteration****************/




    }
}
