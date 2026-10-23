/*
* Name: Preston Offutt  
* Course: CSCI 1250, Section 001
* Assignment: Lab 6, The Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
*              independent exercises or all three at once. Each exercise
*              practices decisions and one of the four loops.
*/

Random rng = new Random(4000);
int userChoice = 0;

//do while: runs once automatically and keeps the program active until user enters the exit option
do
{
    userChoice = 0;
    System.Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker\n2. The Dice Table\n3. The Score Report\n4. All three\n5. Quit");

    //While: used to validate inputs.  reprints instructions until user enters a valid input
    while (userChoice < 1 || userChoice > 5)
    {
       
        System.Console.Write("Choose 1 through 5: ");
        userChoice = Convert.ToInt32(System.Console.ReadLine());
        if (userChoice < 1 || userChoice > 5)
        {
            System.Console.WriteLine("Choose a number from 1 to 5");
        }
    }   
        //Grade Checker
        if (userChoice == 1 || userChoice == 4)
        {   
            System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");
            double gradePercent = -1;
            while (gradePercent < 0 || gradePercent > 100)
            {
              
                System.Console.Write("\nScore: ");
                gradePercent = Convert.ToDouble(Console.ReadLine());
                if (gradePercent < 0 || gradePercent > 100)
                {
                    Console.Write("A score must be between 0 and 100");
                }
                else if (gradePercent >= 90)
                {
                    System.Console.WriteLine($"{gradePercent} earns an A");
                }
                else if (gradePercent >= 80)
                {
                    System.Console.WriteLine($"{gradePercent} earns a B");
                }
                else if (gradePercent >= 70)
                {
                    System.Console.WriteLine($"{gradePercent} earns a C");
                }   
                else if (gradePercent >= 60)
                {
                    System.Console.WriteLine($"{gradePercent} earns a D");
                }
                else
                {
                    System.Console.WriteLine($"{gradePercent} earns an F");
                }
            }

        } //Dice Roller
        if (userChoice == 2 || userChoice == 4)
        {
            
            int rollNum = 1;
            char keepRolling = 'y';
            int userWins = 0;
            System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");

            //while loop: to allow user to keep rolling until satisfied
            while (keepRolling == 'y' || keepRolling != 'n')
            {
                int dieOne = rng.Next(1,7);
                int dieTwo = rng.Next(1,7);
                keepRolling = 'n';
                int dieTotal = dieOne + dieTwo;
                System.Console.Write($"Roll {rollNum}: {dieOne} and {dieTwo}, total: {dieTotal}. ");
                if (dieOne == dieTwo && dieOne == 1)
                {
                    System.Console.Write("Snake eyes.");
                }
                else if (dieOne == dieTwo)
                {
                    System.Console.Write("Doubles!");
                }
                else if (dieTotal == 7 || dieTotal == 11)
                {
                    System.Console.Write("Winner!");
                    userWins += 1;
                }

                //do while to run initially then continue to loop if user does not enter a valid option
                do
                {
                    System.Console.Write("\nRoll again? (y/n): ");
                    keepRolling = Convert.ToChar(Console.ReadLine().Trim().ToLower());
                    if (keepRolling != 'y' && keepRolling != 'n')
                    {
                        System.Console.WriteLine("Please enter 'y' or 'n' only");
                    }
                    if (keepRolling == 'n')
                    {
                    System.Console.WriteLine($"You rolled {rollNum} times and won {userWins}.");
                    }
                }while(keepRolling != 'y' && keepRolling != 'n');  
                rollNum += 1;  
            }   
        }

        //Score Report
        if (userChoice == 3 || userChoice == 4)
        {
            int total = 0;
            int[] scores = new int[5];
            int passingScores = 0;
            int highestScore = 0;
            System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");

            //for loop beacuse it tracks position to put each score in their own spot in the array.
            for (int i = 0; i < scores.Length; i++)
            {
                System.Console.Write($"Score {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine().Trim());
                
            }

            //foreach to itterate through the array cleanly without the need to track position.
            foreach (int score in scores)
            {
                highestScore = Math.Max(highestScore, score);
                total += score;
                if (score >= 60)
                {
                    passingScores += 1;
                } 

            }
            
            System.Console.WriteLine($"\nScores entered: {scores.Length}\nTotal: {total}");
            System.Console.WriteLine($"Average: {(double)total / scores.Length}\nHighest: {highestScore}\nPassing: {passingScores} of {scores.Length}");
        }
}while (userChoice !=5);

System.Console.WriteLine("\n========\nGoodbye\n========");