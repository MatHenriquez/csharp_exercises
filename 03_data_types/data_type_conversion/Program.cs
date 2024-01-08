using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

int first = 2;
string second = "4";
//int result = first + second; // Error
string result = first + second; // 24
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt; // It will not lose information
Console.WriteLine($"decimal: {myDecimal}");

myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); // It will lose information

myDecimal = 1.23456789m;
float myFloat = (float)myDecimal; // It will lose precition
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");

int firstInt = 5;
int secondInt = 7;
string message = firstInt.ToString() + secondInt.ToString();
Console.WriteLine(message);


string firstStr = "5";
string secondStr = "7";
int sum = int.Parse(firstStr) + int.Parse(secondStr);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result1 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result1);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value0 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value0);

//string name = "Bob";
//Console.WriteLine(int.Parse(name)); // Error.

//string myString = "102";
int myResult = 0;
string myString2 = "bad";
if (int.TryParse(myString2, out myResult))
    Console.WriteLine($"Measurement: {myResult}");
else
    Console.WriteLine("Unable to report the measurement.");

if (myResult > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + myResult}");

Console.WriteLine("---- CHALLENGE 1 ----");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string myMessage = "";
decimal total = 0m;
decimal currentValue;

foreach (string myValue in values)
{
    if (decimal.TryParse(myValue, out currentValue))
        total += currentValue;

    else
        myMessage += myValue;
}

Console.WriteLine($"Message: {myMessage}");
Console.WriteLine($"Total: {total}");

Console.WriteLine("---- CHALLENGE 2 ----");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");