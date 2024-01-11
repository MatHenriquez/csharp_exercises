namespace Alphanumeric_Data;

class Program
{
    static void Main(string[] args)
    {
        string firstWord = "Hello";
        string secondWord = "World";
        string message = string.Format("{0} {1}!", firstWord, secondWord);

        Console.WriteLine("");
        Console.WriteLine("Composite format...");
        Console.WriteLine(message); // Hello World!
        Console.WriteLine("{1} {0}!", firstWord, secondWord); // World Hello!
        Console.WriteLine("{0} {0} {0}!", firstWord, secondWord); // Hello Hello Hello!

        Console.WriteLine("");
        Console.WriteLine("String interpolation (best practice)...");
        Console.WriteLine($"{firstWord} {secondWord}!");
        Console.WriteLine($"{secondWord} {firstWord}!");
        Console.WriteLine($"{firstWord} {firstWord} {firstWord}!");
    }
}