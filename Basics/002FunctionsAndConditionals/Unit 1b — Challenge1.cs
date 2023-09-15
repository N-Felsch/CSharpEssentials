/*    Challenge 1: Weather Adviser

   Enhance the "Temperature Adviser" program from the lab assignment. Modify the existing code to check for different 
   temperature ranges and provide more specific advice based on the conditions. Customize the messages based on the 
   temperature conditions to provide detailed weather advice. For example, if the temperature is below 10 degrees Celsius, 
   suggest wearing warm clothing. I recommend carrying a light jacket if the temperature is between 10 and 20 degrees Celsius. */

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
		if (stringToInt <= 10) {
			Console.WriteLine("Please be sure to wear warm clothing, it's a cold one out there.");
        // If temp is below 30 degrees Celsius WriteLine enjoy pleasant weather
		} else if (stringToInt >= 10 && stringToInt <= 20) {
			Console.WriteLine("We recommend carrying a light jacket, just in case you get a little cold.");
		} else if (stringToInt >= 20 && stringToInt <= 30) {
			Console.WriteLine("Today should have great weather.");
		} else {
			Console.WriteLine("Today may-be a little hot, stay hydrated.");
		}
	}
}
