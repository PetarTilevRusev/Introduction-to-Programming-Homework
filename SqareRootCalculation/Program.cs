using System;
                /* Problem 8. Square Root
                    Create a console application that calculates and prints the square root of the number 12345.
                      Find in Internet “how to calculate square root in C#”. */

class SquareRootCalculation
{
    static void Main()
    {
        Console.WriteLine("Press \"Enter\" to run the program!");
        Console.ReadLine();

        Console.WriteLine("Square root of the number 12345 is: {0}", Math.Sqrt(12345));
    }
}

