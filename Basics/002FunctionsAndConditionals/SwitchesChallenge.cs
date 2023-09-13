// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.


/* I didn't just copy and paste this by the way, I built it from scratch, I just took the idea and wanted to replicate it
because it makes the most sense to me. But I do want to spend more time messing around with switches. */

using System;
					
public class DayOfWeekGetter 
{

    public void Main() {
		
        // Get what day of the week
        Console.WriteLine("What day of the week is it?: ");
		// Read user input and set to a string var
		string userDay = Console.ReadLine();
        // Force to int
        int dayOfWeekForced = Convert.ToInt32(userDay);
        
        // Run the switch / day of week finder outer
        switch(dayOfWeekForced)
        {
            case 1:
                Console.WriteLine("The day is Monday");
                break;
            case 2:
                Console.WriteLine("The day is Tuesday");
                break;
            case 3:
                Console.WriteLine("The day is Wednesday");
                break;
            case 4:
                Console.WriteLine("The day is Thursday");
                break;
            case 5:
                Console.WriteLine("The day is Friday");
                break;
            case 6:
                Console.WriteLine("The day is Saturday");
                break;
            case 7:
                Console.WriteLine("The day is Sunday");
                break;
        }
    }
}
        




