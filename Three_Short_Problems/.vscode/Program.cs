/*
* Name: Preston Offutt  
* Course: CSCI 1250, Section 001
* Assignment: Lab 6, The Three Short Problems
* Date: October 21, 2026
* Description: Gives menu of three small working programs.
*/

Random rng = new Random(4000);
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
    }   //Grade Checker
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
        } //Dice Roller
        if (userChoice == 2 || userChoice == 4)
        {
            
            int rollNum = 1;
            char keepRolling = 'y';
            int userWins = 0;
            System.Console.WriteLine("\n=== Dice Table ===");

            //while loop: to allow user to keep rolling until satisfied
            while (keepRolling == 'y' || keepRolling != 'n')
            {
                int dieOne = rng.Next(1,7);
                int dieTwo = rng.Next(1,7);
                keepRolling = 'n';
                int dieTotal = dieOne + dieTwo;
                System.Console.Write($"\nRoll {rollNum}: {dieOne} and {dieTwo}, total: {dieTotal}. ");
                if (dieOne == dieTwo && dieOne == 1)
                {
                    System.Console.WriteLine("Snake eyes.");
                }
                else if (dieOne == dieTwo)
                {
                    System.Console.WriteLine("Doubles!");
                }
                else if (dieTotal == 7 || dieTotal == 11)
                {
                    System.Console.WriteLine("Winner!");
                    userWins += 1;
                }
                //do while to run initially then continue to loop if user does not enter a valid option
                do
                {
                    System.Console.WriteLine("\nWould you like to roll again? y/n:");
                    keepRolling = Convert.ToChar(Console.ReadLine().Trim().ToLower());
                    if (keepRolling != 'y' && keepRolling != 'n')
                    {
                        System.Console.WriteLine("Please enter 'y' or 'n' only");
                    }
                    if (keepRolling == 'n')
                    {
                    System.Console.WriteLine($"You rolled {rollNum} times and won {userWins} times!");
                    }
                }while(keepRolling != 'y' && keepRolling != 'n');  
                rollNum += 1;  
            }   
        }
        //Score Report
        if (userChoice == 3 || userChoice == 4)
        {
            int[] scores = new int[5];
            System.Console.WriteLine("\n=== Score Report ===");
            System.Console.Write($"\nPlease input score{i + 1}: ");
        }
}while (userChoice !=5);

System.Console.WriteLine("\n========\nGoodbye\n========");