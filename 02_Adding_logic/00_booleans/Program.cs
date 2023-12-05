Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1 == value2);
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());