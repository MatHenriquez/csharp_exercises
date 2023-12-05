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

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue3 = "a";
Console.WriteLine(myValue3 != "a");

string value4 = " a";
string value5 = "A ";

Console.WriteLine(value4 != value5);
Console.WriteLine(value4.Trim().ToLower() != value5.Trim().ToLower());