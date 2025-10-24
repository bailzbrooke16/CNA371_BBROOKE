using System;

class Program
{
    static void Main()
    {
        // My CNA371 assignment - Bailey Brooke
        // This checks if you can get into Belgium Campus IT programs
        
        Console.WriteLine("=== Belgium Campus Admission Checker ===");
        Console.WriteLine("Hey there! Let's see if you qualify for our IT programs");
        Console.WriteLine();
        
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        
        // First check - do they have NSC?
        Console.Write("Do you have NSC (matric) certified by Umalusi or SAQA equivalent? (y/n): ");
        string answer1 = Console.ReadLine();
        
        if(answer1.ToLower() != "y")  // I learned ToLower() is better than checking both y and Y
        {
            Console.WriteLine();
            Console.WriteLine("Ah sorry " + name + ", you need NSC (matric) to get in :(");
            Console.WriteLine("It has to be certified by Umalusi or if you're from overseas,");
            Console.WriteLine("you need SAQA to convert your qualification first.");
            Console.WriteLine();
            Console.WriteLine("Thanks for trying though! Press Enter to exit...");
            Console.ReadLine();
            return;
        }
        
        // OK cool, they have NSC. Now let's get more details
        Console.WriteLine("Great! Now I need to check what your NSC is endorsed for...");
        Console.Write("Is it endorsed for Diploma? (y/n): ");
        string diplomaAnswer = Console.ReadLine();
        
        Console.Write("Is it endorsed for Degree? (y/n): ");  
        string degreeAnswer = Console.ReadLine();
        
        Console.Write("What % did you get for English? (put 0 if you didn't take it): ");
        string englishInput = Console.ReadLine();
        int englishMark = int.Parse(englishInput);  // Should probably use TryParse but this works
        
        Console.Write("What % for pure Maths? (put 0 if you didn't take it): ");
        string mathsInput = Console.ReadLine(); 
        int mathsMark = int.Parse(mathsInput);
        
        // Time to check what they qualify for!
        Console.WriteLine();
        Console.WriteLine("OK " + name + ", let me check what you can study...");
        Console.WriteLine("============================================");
        
        bool canStudySomething = false;
        
        // Diploma check - just needs diploma endorsement
        if (diplomaAnswer.ToLower() == "y")
        {
            Console.WriteLine("✓ YES - Diploma in Information Technology");
            Console.WriteLine("  You have NSC for diploma, so you're good to go!");
            canStudySomething = true;
        }
        else
        {
            Console.WriteLine("✗ NO - Diploma in Information Technology");  
            Console.WriteLine("  Your NSC needs to be endorsed for diploma");
        }
        
        Console.WriteLine();
        
        // Now check the degree programs - these are trickier
        if (degreeAnswer.ToLower() == "y")
        {
            // They have degree endorsement, now check English and Maths
            if (englishMark >= 50 && mathsMark >= 50)
            {
                Console.WriteLine("✓ YES - Bachelor of Information Technology (BIT)");
                Console.WriteLine("  NSC for degree ✓, English " + englishMark + "% ✓, Maths " + mathsMark + "% ✓");
                canStudySomething = true;
                
                // Check if they can do BComp too (needs 70% maths)
                if (mathsMark >= 70)
                {
                    Console.WriteLine("✓ YES - Bachelor of Computing (BComp) too!");
                    Console.WriteLine("  Your maths is " + mathsMark + "% which is above the 70% needed");
                }
                else
                {
                    Console.WriteLine("✗ NO - Bachelor of Computing (BComp)");  
                    Console.WriteLine("  You need 70% for maths but got " + mathsMark + "%");
                }
            }
            else
            {
                // Missing requirements
                Console.WriteLine("✗ NO - Bachelor degrees");
                if (englishMark < 50) 
                {
                    Console.WriteLine("  English too low: " + englishMark + "% (need 50%)");
                }
                if (mathsMark < 50)
                {
                    Console.WriteLine("  Maths too low: " + mathsMark + "% (need 50%)");
                    if (mathsMark > 0)  // They actually took maths
                    {
                        Console.WriteLine("  BUT WAIT! You can do our Maths Bridging Course");
                        Console.WriteLine("  Get 50% = qualify for BIT, get 70% = qualify for BComp");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("✗ NO - Bachelor degrees");
            Console.WriteLine("  Your NSC needs to be endorsed for degree study");
        }
        
        Console.WriteLine();
        if (!canStudySomething)
        {
            Console.WriteLine("Don't worry " + name + "! Here's what you need:");
            Console.WriteLine();
            Console.WriteLine("For ANY program: NSC certified by Umalusi (or SAQA if foreign)");
            Console.WriteLine("For Diploma IT: NSC endorsed for diploma");  
            Console.WriteLine("For Bachelor degrees: NSC endorsed for degree + 50% English + 50% Maths");
            Console.WriteLine("For BComp specifically: Same as above but 70% Maths");
            Console.WriteLine();
            Console.WriteLine("Remember: If your maths is under 50%, try our bridging course!");
        }
        else
        {
            Console.WriteLine("Nice one " + name + "! You've got options :)");
        }
        
        Console.WriteLine();
        Console.WriteLine("That's it! Hope this helped.");
        Console.WriteLine("(This was made for my CNA371 assignment - Bailey)");
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
}