using System;
                /* Problem 6. Print Numbers
                    Write a program to print the numbers 1, 101 and 1001, each at a separate line.
                     Name the program correctly. */
class PrintNumbersProgram
{
    static void Main()
    {
        Console.WriteLine("Press \"Enter\" to run the program!");
        Console.ReadLine();

        int[] numbers = new int[] {1, 101, 1001};
        Console.WriteLine("{0} \n{1} \n{2}", numbers[0], numbers[1], numbers[2]);
    }
}

