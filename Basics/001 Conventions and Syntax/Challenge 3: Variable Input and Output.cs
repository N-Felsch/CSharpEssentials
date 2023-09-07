/*    Enhance your program to include user input. 
Prompt the user to enter values for variables and use those values in your calculations or display them on the console. */
	
      // Type your username and press enter
      Console.WriteLine("Enter username:");

      // Create a string variable and get user input from the keyboard and store it in the variable
      string userName = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      Console.WriteLine("Username is: " + userName);
		
	  // ^Not my code above
		
	  // Down below is my code
		
	  // Print what is your favorite number
	  Console.WriteLine("What is your favorite number (please only include integers)? ");
	  // Set user input as a string and store in getFavNum
	  string getFavNum = Console.ReadLine();
	  // Print your favorite number
	  Console.WriteLine("Your favorite number is, " + getFavNum);
	  // Trying some calculations with favorite number
	  Console.WriteLine("Lets do some math, enter a number ");
	  string getNumForMath = Console.ReadLine();
	  Console.WriteLine("What is another number? ");
	  string getNumForMath2 = Console.ReadLine();
	  // Here we are converting the strings to integers and storing them as such
	  int mathCalc = Convert.ToInt32(getNumForMath);
	  int mathCalc2 = Convert.ToInt32(getNumForMath2);
	  // Here is where we display the math and operate on it all at once, interestingly order of operations plays a role here too
	  Console.WriteLine("Lets add your first number from your second " + (mathCalc + mathCalc2));
	  Console.WriteLine("Lets divide your first number by your second " + (mathCalc / mathCalc2));