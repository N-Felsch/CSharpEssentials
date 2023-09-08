//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	// Declaring a third hero type
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		// Declaring the third hero
		heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;

		// Setting up the superior health and power level
		heroThree.health = 10;
		heroThree.powerLevel = 25;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);

		// Printing to the console health and power
		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);

	}
}

// Here we are going into the Hero class, getting the public int's of the heros, for health and powerlevel and printing them to the console.
public class Hero {
	public int health;
	public int powerLevel;
}