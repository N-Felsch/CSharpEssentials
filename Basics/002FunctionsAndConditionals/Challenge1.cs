/* 
   Challenge 1: Temperature Adviser
   Create a program that asks the user to enter the current temperature in Celsius. 
   Use an "if" statement to check if the temperature exceeds 30 degrees Celsius. 
   If it is, display a message suggesting the user stay hydrated and avoid staying in the sun for too long. 
   If the temperature is below 30 degrees Celsius, display a message suggesting the user enjoys the pleasant weather.
*/

using System;

public class TemperatureAdviceGiver
{

public void Main() {

    // Get user input
 	Console.WriteLine("Enter Temperature (only whole numbers please): ");


    // Check if temp is greater than 30 degrees Celsius
    string currentTemp = Console.ReadLine();

    // Convert string to int
    int stringToInt = Convert.ToInt32(currentTemp);

        // If it is, WriteLine to stay hydrated and avoid staying in sun for too long
		if (stringToInt >= 30) {
			Console.WriteLine("Avoid staying in the sun for to long.");
        // If temp is below 30 degrees Celsius WriteLine enjoy pleasant weather
		} else {
			Console.WriteLine("Enjoy the pleasant weather.");
		}
	}
}





