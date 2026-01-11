using System;

using System.Collections.Generic;

class TimeConverter
{
    // List stores all converted results
    static List<int> convertedMinutes = new List<int>();

    public static void Main(string[] args)
    {
       
        while (true) // Program runs unless the user chooses to stop
        {
            
            int hours = ReadNumber("Enter hours: ");// Reads the input from the user
            int minutes = ReadNumber("Enter minutes: ");

            // To check whether the input is valid or not
            if (minutes < 0 || minutes > 59 || hours < 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                // Converts and saves the result
                int totalMinutes = ConvertToMinutes(hours, minutes);
                convertedMinutes.Add(totalMinutes);
                Console.WriteLine("Total time in minutes: " + totalMinutes);
            }

            // Asks the user to continue or stop 
            Console.WriteLine("Do you want to continue? (yes/no): ");
            string answer = Console.ReadLine()??"";

            if (answer != "yes")
            {
                break;
            }
        }
        PrintList(); 
    }
    // Reads a number from the user
    public static int ReadNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    // Converts hours and minutes into total minutes
    public static int ConvertToMinutes(int hours, int minutes)
    {
        return hours * 60 + minutes;
    }
    // Prints the list of converted times
    public static void PrintList()
    {
        Console.WriteLine("Converted times:");
        foreach (int number in convertedMinutes)
        {
            Console.WriteLine(number);
        }
    }
}


