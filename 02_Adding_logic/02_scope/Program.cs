// Scope

using System;

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

// Scope challenge

/*
 * Fix the code to get this output:
 * Set contains 42
 * Total: 108
 * 
 * Code:
 * int[] numbers = { 4, 8, 15, 16, 23, 42 };
 * 
 * foreach (int number in numbers)
 * {
 *  int total;
 *
 *    total += number;
 *
 *    if (number == 42)
 *    {
 *       bool found = true;
 *
 *    }
 *
 * }
 *
 * if (found) 
 * {
 *     Console.WriteLine("Set contains 42");
 * 
 * }
 * 
 * Console.WriteLine($"Total: {total}");
 */

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int totalSum = 0;

foreach (int number in numbers)
{
    totalSum += number;
    if (number == 42)
        Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {totalSum}");

// Microfost's solution

int[] numbers2 = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers2)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");