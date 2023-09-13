/*
Challenge 2: Exam Grader
   Extend your program to prompt users to enter their exam scores as percentages. 
   Use an "if-else" statement to check the score and provide a corresponding grade. 
   For example, if the score is between 90 and 100, display an "A" grade message. 
   If the score is between 80 and 89, display a "B" grade message, and so on. 
   Provide appropriate feedback for various score ranges.
*/

using System;

// Delcaring a new class to work in called the grader
public class Grader {

    // The main body is where everything is run within the Console from what I know
    public void Main() {

    // Get user input for exam as %
    Console.WriteLine("What score did you get on your exam, as a percentage?: ");
    // Having the console store user input as variable
    string userScore = Console.ReadLine();
    // Force convert to int
    int forceScoreInt = Convert.ToInt32(userScore);

        // Use if / else statements to provide grade (if above this, than this, else if, etc) and write there grades
        if (forceScoreInt >= 90) {
            Console.WriteLine("You have an A, congratulations!");
        } else if (forceScoreInt < 90 && forceScoreInt >= 80) {
            Console.WriteLine("You have a B, yay!"); 
        }   else if (forceScoreInt < 80 && forceScoreInt >= 70) {
            Console.WriteLine("You have a C, c's do get degrees, but not ideally.");
        }   else if (forceScoreInt < 70 && forceScoreInt >= 60) {
            Console.WriteLine("You have a D in the class, please try harder.");
        }   else  {
            Console.WriteLine("You are failing, please ask for help.");
        }
    }
}
        




