using System;

namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
        string name = "Shadow";
        string breed = "Golden Retriever";
        int age = 5;
        double weight = 65.22;
        bool spayed = true;
      // Print variables to the console
        Console.WriteLine(name);
        Console.WriteLine(breed);
        Console.WriteLine(age);
        Console.WriteLine(weight);
        Console.WriteLine(spayed);
    }
  }
}

using System;


//Here we are just debugging some code in the compiler, this is already debugged.
namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      double number = 38498.3222;

      string dinosaur = "Barney";

      int lockCode = 293;

      bool AnswerYes = true;

      string band = "The Low Anthem";

    }
  }
}

using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      int faveNumber = Convert.ToInt32(Console.ReadLine());


    }
  }
}

using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      DATA TYPES: int, double, char, string, bool
      VARIABLES: datatype variableName = value;
      COMMON ERRORS: wrong type, wrong value, no semicolon
      DATA TYPE CONVERSION: implicit, explicit, methods

      Good luck! */

      //Turning a bool into a string
      bool myBool = true;
      Console.WriteLine(myBool.ToString());

      //Turning a string into a list of chars
      string myString = "I'm Learning";
      //Here we are taking the string and turning it
      //into an array
      char[] myStringOfChar = myString.ToCharArray();
      //And here we pring the array, well, the char
      Console.WriteLine(myStringOfChar);

      //Converting an int into a bool
      int myInt = 3;
      bool myBool2 = Convert.ToBoolean(myInt);
      Console.WriteLine(myBool2);

      //What if the int was 0
      int myInt2 = 0;
      bool myBool3 = Convert.ToBoolean(myInt2);
      Console.WriteLine(myBool3);


    }
  }
}

using System;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizza shops
      int pizzaShops = 4332;

      // Number of employees
      int totalEmployees = 86928;

      // Revenue
      decimal revenue = 390819.28m;

      // Log the values to the console:
      Console.WriteLine(pizzaShops);
      Console.WriteLine(totalEmployees);
      Console.WriteLine(revenue);
   	}
  }
}

// I tried jazzing it up to include the title of ages, but CodeAcademy wouldn't let me.
using System;


//Here we are calculating our age on Jupiter and on Earth and how long it would take to get there and our age when we did.
namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 26;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;
    
      // Age on Jupiter
      double jupiterAge = userAge/jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge / jupiterYears;

      // Log calculations to console
      Console.WriteLine(userAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newJupiterAge); 


    }
  }
}


//Here we are using operators and experimenting
using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      steps = steps + 2;

      // One step back 
      steps = steps - 1;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}


//More operator experimentation
using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;

      // Number of students in a group
      int groupSize = 5;

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}

//Here we are using the built in methods to convert variables into different data types
using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      // Print the lowest number
      Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

    }
  }
}

//Using more built in operators to interpret numbers, doubles, ints.
using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {

      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));

    }
  }
}
