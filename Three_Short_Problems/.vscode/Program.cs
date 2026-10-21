/*
* Name: Preston Offutt  
* Course: CSCI 1250, Section 001
* Assignment: Lab 6, The Three Short Problems
* Date: October 21, 2026
* Description: Gives menu of three small working programs.
*/


int userChoice = 0;
//do while: runs once automatically and keeps the program active until user enters the exit option
do
{
userChoice = 0;
//While: used to validate inputs.  reprints instructions until user enters a valid input
while (userChoice < 1 || userChoice > 5)
{
    System.Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker\n2. The Dice Table\n3. The Score Report\n4. All three\n5. Quit");
    System.Console.Write("\nPlease make a selection from the menu: ");
    userChoice = Convert.ToInt32(System.Console.ReadLine());
    if (userChoice < 1 || userChoice > 5)
    {
        System.Console.WriteLine("\nYou have entered an invalid option. Please try again");
    }
}
    if (userChoice == 1 || userChoice == 4)
    {   
        double gradePercent = -1;
        while (gradePercent < 0 || gradePercent > 100)
        {
            System.Console.WriteLine("\n=== Grade Checker ===");
            System.Console.Write("\nPlease Enter your grade: ");
            gradePercent = Convert.ToDouble(Console.ReadLine());
            if (gradePercent < 0 || gradePercent > 100)
            {
                Console.Write("You have entered an invalid grade. Try again.");
            }
            if (gradePercent >= 90)
            {
                System.Console.WriteLine("Your grade is an A");
            }
            else if (gradePercent >= 80)
            {
                System.Console.WriteLine("Your grade is a B");
            }
            else if (gradePercent >= 70)
            {
                System.Console.WriteLine("Your grade is a C");
            }
            else if (gradePercent >= 60)
            {
                System.Console.WriteLine("Your grade is a D");
            }
            else
            {
                System.Console.WriteLine("Your grade is an F");
            }
        }
    }
    if (userChoice == 2 || userChoice == 4)
    {
    System.Console.WriteLine("\n=== Dice Table ===");
    System.Console.Write("\nYour Dice roll: ");
    }
    if (userChoice == 3 || userChoice == 4)
    {
    System.Console.WriteLine("\n=== Score Report ===");
    System.Console.Write("\nPlease Enter your score: ");
    }
}while (userChoice !=5);

System.Console.WriteLine("\n========\nGoodbye\n========");