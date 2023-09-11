// Just playing around with functions

using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Hello World");

        // Declaring the function I created below.
		LetsMath(44);
	}
	
    // Declaring the LetsMath function that crunches numbers
	public void LetsMath(int numberUser) {
		var num4 = 4;
		var num3 = 3 + numberUser;
		var testTest = numberUser;
		
        // Here we are adding the two variables above and the argument passed to LetsMath in Main above.
		var adding = num4 + num3 + testTest;

        // Printing to the line this function
		Console.WriteLine(adding);
	}
	
}

            // This is my VCS for the code above, beep, boop, bop

            using System;
                                
            public class Program
            {
                // Declaring the Operations class we created down under
                public Operations myOperators;
                    
                public void Main() 
                
                {
                    // Creating a new instance of the Operations class named myOperators
                    myOperators = new Operations();
                    
                    Console.WriteLine("Hello World");
                    myOperators.LetsMath(44, 23);
                    myOperators.Compare(1, 2);
                    myOperators.Compare(2,2);
                    myOperators.PasswordChecker("TheFragle");
                }

            }

            // Declaring a new Operations class
            public class Operations {
                    
                // We are taking in two arguements, woop woop! Also doing the same math.
                public void LetsMath(int numberUser, int numberUser2) {
                    var num4 = 4;
                    var num3 = 3 + numberUser;
                    var testTest = numberUser + numberUser2;
                    
                    var adding = num4 + num3 + testTest;
                    Console.WriteLine(adding);
                }
                
                // Comparing two arguements to see which one is greater than the other
                public void Compare(int value1, int value2) {
                    if(value1 >= value2){
                        Console.WriteLine("The first number is equal to or greater than the second");
                    } else {
                        Console.WriteLine("The first number is not equal to or greater than the second");
                    }
                }
                
                // Created a simple password checker using an if statement, like before, but comparing a string to a string
                public void PasswordChecker ( string password) {
                    if ( password == "TheFragile" ) {
                            Console.WriteLine("Incorrect password");
                    Console.WriteLine("The password is correct");
                    } else {
                    }
                }
                // I really wanted to try and see if I could use multiple else if statements in one function and it is possible, yippie!
                     public void TryingElseIf (int firstNum, int secondNum) {
                        if (firstNum > 1 ) {
                             Console.WriteLine("Success, first num is bigger than one");
                        } else if (secondNum > 1) {
                            Console.WriteLine("Success, second num is bigger than one");
                             } else if (firstNum + secondNum >= 3){
                                    Console.WriteLine("We got to the third else if, yay!");
                                } else {
                                    Console.WriteLine("This was a lot of work, but it all worked out");
                                }
                            }
                            
                /* Here we are trying the short hand version of if statements 
                    
                int time = 20;
                string result = (time < 18) ? "Good day." : "Good evening.";
                Console.WriteLine(result);
                        
                 */
                        
                public void TryingShortHand (int num1, int num2) {
                    var returned = (num1 > num2) ? "Number one is greater than number two" : "Number one is not greater than number two";
                    Console.WriteLine(returned);
                }
		
	
                
            }
