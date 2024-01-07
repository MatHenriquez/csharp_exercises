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

string myString = "102";
int myResult = 0;
if (int.TryParse(myString, out myResult))
    Console.WriteLine($"Measurement: {myResult}");
else
    Console.WriteLine("Unable to report the measurement.");

Console.WriteLine($"Measurement (w/ offset): {50 + myResult}");