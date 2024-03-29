﻿namespace Alphanumeric_Data;
class Program
{
    static void Main(string[] args)
    {
        //string firstWord = "Hello";
        //string secondWord = "World";
        //string message = string.Format("{0} {1}!", firstWord, secondWord);

        //Console.WriteLine("");
        //Console.WriteLine("Composite format...");
        //Console.WriteLine(message); // Hello World!
        //Console.WriteLine("{1} {0}!", firstWord, secondWord); // World Hello!
        //Console.WriteLine("{0} {0} {0}!", firstWord, secondWord); // Hello Hello Hello!

        //Console.WriteLine("");
        //Console.WriteLine("String interpolation (best practice)...");
        //Console.WriteLine($"{firstWord} {secondWord}!");
        //Console.WriteLine($"{secondWord} {firstWord}!");
        //Console.WriteLine($"{firstWord} {firstWord} {firstWord}!");

        //Console.WriteLine("");
        //Console.WriteLine("Formatting currency values...");

        //decimal price = 123.45m;
        //int discount = 50;
        //Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        //Console.WriteLine("");
        //Console.WriteLine("Formatting numeric values...");

        //decimal measurement = 123456.78912m;
        //Console.WriteLine($"Measurement: {measurement:N} units");
        //Console.WriteLine($"Measurement: {measurement:N4} units");

        //Console.WriteLine("");
        //Console.WriteLine("Formatting percentage values...");
        //decimal tax = .36785m;
        //Console.WriteLine($"Tax rate: {tax:P2}");

        //Console.WriteLine("");
        //Console.WriteLine("Combined examples...");

        //decimal regularPrice = 67.55m;
        //decimal salePrice = 59.99m;
        //string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (regularPrice - salePrice), regularPrice);
        //Console.WriteLine(yourDiscount);

        //yourDiscount += $"A discount of {((regularPrice - salePrice) / regularPrice):P2}!";
        //Console.WriteLine(yourDiscount);

        //// Shares exercise
        //int invoiceNumber = 1021;
        //decimal productShares = 25.4568m;
        //decimal subtotal = 2750.00m;
        //decimal taxPercentage = .15825m;
        //decimal total = 3185.19m;

        //Console.WriteLine($"Invoice Number Number: {invoiceNumber}");
        //Console.WriteLine($"    Shares: {productShares:N3} Product");
        //Console.WriteLine($"    Sub Total: {subtotal:C}");
        //Console.WriteLine($"        Tax: {taxPercentage:P2}");
        //Console.WriteLine($"    Total Billed: {total:C}");

        //string input = "Pad this";
        //Console.WriteLine(input.PadLeft(12)); // new string's length is 12 (8 chars + 4 blank spaces on the left).
        //Console.WriteLine(input.PadRight(12)); // new string's length is 12 (8 chars + 4 blank spaces on the rigth).

        //// Overloaded methods
        //Console.WriteLine(input.PadLeft(12, '-')); 
        //Console.WriteLine(input.PadRight(12, '-'));

        //string paymentId = "769C";
        //string payeeName = "Mr. Stephen Ortega";
        //string paymentAmount = "5,000.0";
        //var formattedLine = paymentId.PadRight(6);
        //formattedLine += payeeName.PadRight(24);
        //formattedLine += paymentAmount.PadLeft(10);

        //Console.WriteLine("1234567890123456789012345678901234567890");
        //Console.WriteLine(formattedLine);

        // Exercise

        //Dear Ms. Barros,
        //As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

        //Currently, you own 2,975,000.00 shares at a return of 12.75 %.

        //Our new product, Glorious Future offers a return of 13.13 %.Given your current volume, your potential profit would be ¤63,000,000.00.

        //Here's a quick comparison:

        //Magic Yield         12.75 %   $55,000,000.00
        //Glorious Future     13.13 %   $63,000,000.00

        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        //Magic Yield         12.75 %   $55,000,000.00      
        //Glorious Future     13.13 %   $63,000,000.00  

        // Your logic here

        string completeMessage = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n\nHere's a quick comparison:\n\n{currentProduct.PadRight(19)} {currentReturn:P2} {"".PadRight(1)} {currentProfit:C2}\n{newProduct.PadRight(19)} {newReturn:P2} {"".PadRight(1)} {newProfit:C2}";

        Console.WriteLine("");
        Console.WriteLine(completeMessage);
        Console.WriteLine("");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "Dear Ms. Barros,\r\nAs a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n\r\nCurrently, you own 2,975,000.00 shares at a return of 12.75 %.\r\n\r\nOur new product, Glorious Future offers a return of 13.13 %. Given your current volume, your potential profit would be $ 63,000,000.00.\r\n\r\nHere's a quick comparison:\r\n\r\nMagic Yield         12.75 %   $55,000,000.00      \r\nGlorious Future     13.13 %   $63,000,000.00  ";

        // Your logic here

        Console.WriteLine(comparisonMessage);

        // Microsoft's solution

        //string customerName = "Ms. Barros";

        //string currentProduct = "Magic Yield";
        //int currentShares = 2975000;
        //decimal currentReturn = 0.1275m;
        //decimal currentProfit = 55000000.0m;

        //string newProduct = "Glorious Future";
        //decimal newReturn = 0.13125m;
        //decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        //string comparisonMessage = "";

        comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

        Console.WriteLine(comparisonMessage);
    }
}