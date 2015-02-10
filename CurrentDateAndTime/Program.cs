using System;
                /* Problem 14.* Current Date and Time
                    Create a console application that prints the current date and time. Find out how in Internet.*/

class CurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine("Press \"Enter\" to run the program");
        Console.ReadLine();

        Console.WriteLine("Current date and time is: {0}", DateTime.Now);
    }
}

