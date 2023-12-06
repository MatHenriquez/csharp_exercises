// Challenge 01

// My solution
using System.Security;

int result = new Random().Next(0, 2);
Console.WriteLine($"{(result == 1 ? "heads" : "tails")}");

// Microsoft's Solution
Random coin = new Random();
int flip = coin.Next();
Console.WriteLine((flip == 0) ? "heads" : "tails");

// Challenge 02

// My solution
string permission = "Admin|Manager";
int level = 55;
string message = "You do not have sufficient privileges.";

if (permission.Contains("Admin")) 
    message = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
else if (permission.Contains("Director")) message = level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";

Console.WriteLine(message);

// Microsoft's solution.

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}