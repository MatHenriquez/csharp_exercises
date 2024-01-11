namespace Alphanumeric_Data;

class Program
{
    static void Main(string[] args)
    {
        string firstWord = "Hello";
        string secondWord = "World";
        string message = string.Format("{0} {1}!", firstWord, secondWord);
        Console.WriteLine(message); // Hello World!
        Console.WriteLine("{1} {0}!"); // World Hello!
        Console.WriteLine("{0} {0} {0}!", firstWord, secondWord); // Hello Hello Hello!
    }
}