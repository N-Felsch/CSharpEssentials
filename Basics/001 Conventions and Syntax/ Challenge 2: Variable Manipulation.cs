/* Extend your program to include variable manipulation. Perform arithmetic operations (addition, subtraction, multiplication, and division)
 on variables of numeric types. Display the results of these operations on the console. */

 //This is just a regular old number, or an integer
int myInt = 5;

//string, is just a bunch of characters, or a line of text, it isn't an array of characters though.. maybe it is?
string myString = "Hello I'm Nicholas";

//bool stands for boolean and it's helpful when you want something to be true or false
bool myBool = true;

//Double can have up to 17 digits saved.
double myDouble = 35.35d;

//Floats can only have up to 9 decimal digits.
float myFloat = 35.5f;

//char stands for character
char myChar = 'N';
//Wow I learned you can't use double "" quotation marks for a char, it has to be single ''
			
//Just calling all of the variables here and writing them on the console, I wonder if there is an easier way to call all of them
Console.WriteLine(myChar);
Console.WriteLine(myFloat);
Console.WriteLine(myDouble);
Console.WriteLine(myBool);
Console.WriteLine(myString);
Console.WriteLine(myInt);

//I'm going to do some math down below.
//Adding some int's and doubles so I can operate
int two = 2;
int four = 4;
//I've heard it's good practice to add the d at the end of a double to specify explicitly
double twoPointOne = 2.1d;
double twoPointThreeTwo = 2.32d;

//Here we are going to store this as an int so its forced to be an int
int minus = four - two;
int adding = two + four;

//Here we're going to see what happens when I add a double to an int
int intSubDouble = four - twoPointOne;
double doubleIntAdd = four + twoPointThreeTwo;


Console.WriteLine()

