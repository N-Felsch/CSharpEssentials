using System;
					
public class Program
{
	public  void Main()
	{
		/* string[] candyBars = {"Galaxy Bar", "Take 2", "3 Amigos", "Crunchy Break", "Peanut Overload", "Easy Break", "Crunchies", "Snix"};
		Console.WriteLine(candyBars[0]);
		Console.WriteLine(candyBars.Length);
		foreach(var candy in candyBars){
			Console.WriteLine(candy);
		for(var i = 0; i < candyBars.Length; i++){
			Console.WriteLine(candy);
			candyBars[i] = "Updated Candy-bars"; 
		}
		} */
		
		Weapon[] weaponClass = {(new Weapon(), new Weapon())};
			weaponClass[0] = "Sniper Rifle";
	}
	public class Weapon
	{
		public string gun = "Pistol";
		public int powerLevel = 1; 
	
	}
	}
}

using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Mustang", "Camaro", "Hellcat", "Corvette", "Viper", "McCleran"};
		
		Console.WriteLine(cars.Length);
		Console.WriteLine(cars[0]);
		Console.WriteLine(cars[1]);
		Console.WriteLine(cars[2]);
		Console.WriteLine(cars[3]);
		Console.WriteLine(cars[4]);
		Console.WriteLine(cars[5]);
		
		Console.WriteLine();
		
		
		string[] candy = {"Cotton Candy", "KitKat"};
		Console.WriteLine(candy.Length);
		foreach(var candyBar in candy) {
			Console.WriteLine("I love " + candyBar + ".");
		}
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		//playerTypes[1] = "Queen";
		
		for(var i = 0; i < playerTypes.Length; i++){
			playerTypes[i] = "Queen";
		}
		
		foreach(var playerType in playerTypes) {
			Console.WriteLine(playerType);
		}
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		// We are getting information from the user, I wonder if there is an easier way to do this
		Console.WriteLine("Input a number: ");
		string userInput = Console.ReadLine();
		int stringToInt = Convert.ToInt32(userInput);
		
		
		for(var i = 0; i <= stringToInt ; i++){
			
			Console.WriteLine(i);
		}
		//Console.WriteLine(stringToInt);
		
		
		
		//int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		
		//for(var i = 0; i <= myArray.Length; i++){
			//Console.WriteLine(i);
		}
		
		//Console.WriteLine(myArray[3]);
	//}
}