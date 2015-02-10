using System;
                /* Problem 15.* Age after 10 Years
                    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years. */
class Program
{
    static void Main()
    {
        Console.Write("Please \"Enter\" your birthday (eg. 01.01.0001): ");
        string userImput = Console.ReadLine();

        string burthDay = userImput.Substring(0, 2);           // Here I take the day of burth from user imput
        string burthMonth = userImput.Substring(3, 2);         // Here I take the month of burth from user imput
        string burthYear = userImput.Substring(6, 4);          // Here I take the year of burth from user imput
        

        int userYearOfBurth;               // Here I make new empty int for user year of burth
        int userMonthOfBurth;              // Here I make new empty int for user month of burth
        int userBurthDay;                  // Here I make new empty int for user day of burth

        System.DateTime CurrentTime = System.DateTime.Now;
        int year = CurrentTime.Year;    // Here I take the current year from System.DateTime.Now
        int month = CurrentTime.Month;  // Here I take the current month from System.DateTime.Now
        int day = CurrentTime.Month;    // Here I take the current day from System.DateTime.Now
        
        

        if(int.TryParse(burthYear, out userYearOfBurth) && 
            int.TryParse(burthMonth, out userMonthOfBurth) && 
            int.TryParse(burthDay, out userBurthDay))            // Here I chek if the user imputs are numbers
        {
            if(userMonthOfBurth <= 12 && userBurthDay <= 31)       // Here I check if the user month and day imputs are currect
            {
                if (userMonthOfBurth > month && userBurthDay > day)       // Here I check if the user burthday isn't passed yet for this year
                {
                    int userAge = (year - userYearOfBurth) - 1;   // Here I calculate the user current age
                    Console.WriteLine("You are {0} years old!", userAge);

                    int futureAge = userAge + 10;       // Here I calculate the user age after 10 years
                    int futureYear = year + 10;         // Here I calculate the year after 10 years
                    Console.WriteLine("You will be {0} years old in {1}", futureAge, futureYear);
                }
                else
                {
                    int userAge = year - userYearOfBurth;         // Here I calculate the user current age
                    Console.WriteLine("You are {0} years old!", userAge);

                    int futureAge = userAge + 10;       // Here I calculate the user age after 10 ye
                    int futureYear = year + 10;         // Here I calculate the year after 10 years
                    Console.WriteLine("You will be {0} years old in {1}", futureAge, futureYear);
                }
            }
            else      // This is console output if the user imput has wrong day or month value
            {
                Console.WriteLine("Your imput is wrong. \nPlease try again!");
            }
        }
        else     // This is console output if the user imput has symbols different from numbers
        {
            Console.WriteLine("Your imput is wrong. \nPlease try again!");
        }

        /* So there are fiew bugs: eg. february has only 28 days, but the user can imput 31.02.2015 with no problems.
            The user can be 2015 years old with no wories. I can easily fix it, but if the user doesn't want to tell his age he can lie anyway.
             The user can imput every symbol as a replecement of "." eg. 01Y01G2015 and it's working just fine.
         */
    }
}

