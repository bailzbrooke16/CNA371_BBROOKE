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
        
        // Check basic qualification
        Console.Write("Do you have a National Senior Certificate (NSC) certified by Umalusi or equivalent SAQA converted qualification? (y/n): ");
        string nscInput = Console.ReadLine();
        bool hasNSC = (nscInput == "y" || nscInput == "Y");
        
        if (!hasNSC)
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, you need a National Senior Certificate (NSC) certified by Umalusi");
            Console.WriteLine("or an equivalent foreign qualification converted by SAQA to qualify for any program.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
            return;
        }
        
        Console.Write("Is your NSC endorsed for Diploma studies? (y/n): ");
        string diplomaEndorsedInput = Console.ReadLine();
        bool isDiplomaEndorsed = (diplomaEndorsedInput == "y" || diplomaEndorsedInput == "Y");
        
        Console.Write("Is your NSC endorsed for Degree studies? (y/n): ");
        string degreeEndorsedInput = Console.ReadLine();
        bool isDegreeEndorsed = (degreeEndorsedInput == "y" || degreeEndorsedInput == "Y");
        
        // Get English percentage
        Console.Write("What percentage did you achieve for English? (Enter 0 if not taken): ");
        int englishPercentage = Convert.ToInt32(Console.ReadLine());
        
        // Get Mathematics percentage
        Console.Write("What percentage did you achieve for pure Mathematics? (Enter 0 if not taken): ");
        int mathsPercentage = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Results for " + studentName + ":");
        Console.WriteLine("----------------------------");
        
        // Check qualifications for each program
        bool qualifiesForSomething = false;
        bool needsBridgingCourse = false;
        
        // Check for Diploma in Information Technology
        if (isDiplomaEndorsed)
        {
            Console.WriteLine("ACCEPTED: Diploma in Information Technology");
            Console.WriteLine("  ✓ NSC endorsed for Diploma");
            qualifiesForSomething = true;
        }
        
        // Check for Degree Programs (Bachelor of IT and Bachelor of Computing)
        if (isDegreeEndorsed)
        {
            bool hasRequiredEnglish = englishPercentage >= 50;
            bool hasRequiredMaths = mathsPercentage >= 50;
            
            if (hasRequiredEnglish && hasRequiredMaths)
            {
                Console.WriteLine("ACCEPTED: Bachelor of Information Technology (BIT)");
                Console.WriteLine("  ✓ NSC endorsed for Degree");
                Console.WriteLine("  ✓ English: " + englishPercentage + "% (50% required)");
                Console.WriteLine("  ✓ Mathematics: " + mathsPercentage + "% (50% required)");
                qualifiesForSomething = true;
                
                // Check for Bachelor of Computing (higher requirement)
                if (mathsPercentage >= 70)
                {
                    Console.WriteLine("ACCEPTED: Bachelor of Computing (BComp)");
                    Console.WriteLine("  ✓ Mathematics: " + mathsPercentage + "% (70% required for BComp)");
                }
                else
                {
                    Console.WriteLine("Note: For Bachelor of Computing, you need 70% in Mathematics (you have " + mathsPercentage + "%)");
                }
            }
            else
            {
                Console.WriteLine("For Degree Programs, you need:");
                if (!hasRequiredEnglish)
                {
                    Console.WriteLine("  ✗ English: " + englishPercentage + "% (50% required)");
                }
                if (!hasRequiredMaths)
                {
                    Console.WriteLine("  ✗ Mathematics: " + mathsPercentage + "% (50% required)");
                    if (mathsPercentage < 50 && mathsPercentage > 0)
                    {
                        Console.WriteLine("  💡 Option: You can attend our Mathematics Bridging Course");
                        Console.WriteLine("     - Achieve 50% for BIT entry or 70% for BComp entry");
                        needsBridgingCourse = true;
                    }
                }
            }
        }
        
        if (!qualifiesForSomething && !needsBridgingCourse)
        {
            Console.WriteLine("Current Requirements Summary:");
            Console.WriteLine("Minimum requirement: NSC certified by Umalusi or SAQA equivalent");
            Console.WriteLine();
            Console.WriteLine("Diploma in Information Technology:");
            Console.WriteLine("  • NSC endorsed for Diploma");
            Console.WriteLine();
            Console.WriteLine("Degree Programmes:");
            Console.WriteLine("  • NSC endorsed for Degree");
            Console.WriteLine("  • 50% or more for English");
            Console.WriteLine("  • 50% or more for pure Mathematics (BIT)");
            Console.WriteLine("  • 70% or more for pure Mathematics (BComp)");
            Console.WriteLine();
            Console.WriteLine("Note: Mathematics Bridging Course available if you scored less than required");
        }
        
        Console.WriteLine();
        Console.WriteLine("Thank you for using our system!");
        Console.Write("Press Enter to close...");
        Console.ReadLine();
    }
}