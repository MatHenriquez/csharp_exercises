// Equality operator

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1 == value2);
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("==================================================");

// Inequality operator

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue3 = "a";
Console.WriteLine(myValue3 != "a");

string value4 = " a";
string value5 = "A ";

Console.WriteLine(value4 != value5);
Console.WriteLine(value4.Trim().ToLower() != value5.Trim().ToLower());

Console.WriteLine("==================================================");

// Comparison operators

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Console.WriteLine("==================================================");

// Methods returning booleans
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));