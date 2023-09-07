/*  Create a program that declares and initializes variables of different data types such as integer, 
floating-point, boolean, and string. Assign meaningful values to these variables and display their values on the console.*/

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