﻿namespace Alphanumeric_Data;

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

        Console.WriteLine("");
        Console.WriteLine("Formatting currency values...");

        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        Console.WriteLine("");
        Console.WriteLine("Formatting numeric values...");

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");
        Console.WriteLine($"Measurement: {measurement:N4} units");

        Console.WriteLine("");
        Console.WriteLine("Formatting percentage values...");
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");

        Console.WriteLine("");
        Console.WriteLine("Combined examples...");

        decimal regularPrice = 67.55m;
        decimal salePrice = 59.99m;
        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (regularPrice - salePrice), regularPrice);
        Console.WriteLine(yourDiscount);

        yourDiscount += $"A discount of {((regularPrice - salePrice) / regularPrice):P2}!";
        Console.WriteLine(yourDiscount);

        // Shares exercise
        int invoiceNumber = 1021;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number Number: {invoiceNumber}");
        Console.WriteLine($"    Shares: {productShares:N3} Product");
        Console.WriteLine($"    Sub Total: {subtotal:C}");
        Console.WriteLine($"        Tax: {taxPercentage:P2}");
        Console.WriteLine($"    Total Billed: {total:C}");
    }
}