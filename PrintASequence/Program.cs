using System;
                /* Problem 9. Print a Sequence
                    Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ... */
class PrintASequence
{
    static void Main()
    {
        Console.WriteLine("Press \"Enter\" to run the program!");
        Console.ReadLine();

        int number = 2;

        for (int i = 0; i < 10; i++)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
                number++;

            }
            else
            {
                int negativeNumbers = number * (-1);
                Console.WriteLine(negativeNumbers);
                number++;
            }
            
        }
    }
}

