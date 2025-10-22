using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Belgium Campus ITversity - Student Qualification Checker");
        Console.WriteLine("========================================================");
        Console.WriteLine();
        
        // Get student details
        Console.Write("Enter your name: ");
        string studentName = Console.ReadLine();
        
        Console.Write("What is your matric percentage? ");
        string input = Console.ReadLine();
        int matricPercentage = Convert.ToInt32(input);
        
        // Check subjects
        Console.Write("Did you pass Mathematics? (y/n): ");
        string mathsInput = Console.ReadLine();
        bool hasMaths = (mathsInput == "y" || mathsInput == "Y");
        
        Console.Write("Did you pass English? (y/n): ");
        string englishInput = Console.ReadLine();
        bool hasEnglish = (englishInput == "y" || englishInput == "Y");
        
        Console.Write("Did you pass Physical Science or Life Sciences? (y/n): ");
        string scienceInput = Console.ReadLine();
        bool hasScience = (scienceInput == "y" || scienceInput == "Y");
        
        Console.WriteLine();
        Console.WriteLine("Results for " + studentName + ":");
        Console.WriteLine("----------------------------");
        
        // Check qualifications for each program
        bool qualifiesForSomething = false;
        
        if (matricPercentage >= 40 && hasMaths && hasEnglish)
        {
            Console.WriteLine("ACCEPTED: Diploma in Information Technology");
            qualifiesForSomething = true;
        }
        
        if (matricPercentage >= 60 && hasMaths && hasEnglish && hasScience)
        {
            Console.WriteLine("ACCEPTED: Bachelor of Information Technology");
            qualifiesForSomething = true;
        }
        
        if (matricPercentage >= 70 && hasMaths && hasEnglish && hasScience)
        {
            Console.WriteLine("ACCEPTED: Bachelor of Computing");
            qualifiesForSomething = true;
        }
        
        if (!qualifiesForSomething)
        {
            Console.WriteLine("Sorry, you don't meet the requirements for any programs.");
            Console.WriteLine("Minimum requirements:");
            Console.WriteLine("- Diploma: 40% + Maths + English");
            Console.WriteLine("- Bachelor degrees: Need Science too + higher marks");
        }
        
        Console.WriteLine();
        Console.WriteLine("Thank you for using our system!");
        Console.Write("Press Enter to close...");
        Console.ReadLine();
    }
}