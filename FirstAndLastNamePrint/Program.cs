using System;
                /* Problem 7. Print First and Last Name
                    Create console application that prints your first and last name, each at a separate line. */
class Program
{
    static void Main()
    {
        Console.WriteLine("Press \"Enter\" to run the program!");
        Console.ReadLine();

        string firstName = "Petar";
        string lastName = "Rusev";
        Console.WriteLine("My fits name is: {0} \nMy last name is: {1}", firstName, lastName);
    }
}

