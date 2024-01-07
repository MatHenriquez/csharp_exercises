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