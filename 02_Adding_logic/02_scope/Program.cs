// Scope

bool flag = true;
int value = 0;
if(flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

Console.WriteLine($"Outside of code block: {value}");

// Readability

// Easy to read
if(flag)
    Console.WriteLine(flag);

// Difficult to read
if (flag) Console.WriteLine(flag);

// Another example

// Difficult to read
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

// Easy to read
string name2 = "steve";

if (name2 == "bob")
    Console.WriteLine("Found Bob");
else if (name2 == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");