for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for(int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for(int i = 0;i < 10; i += 3)
{
    Console.WriteLine(i);
}

for(int i = 0; i < 10; i++)
{
    Console.Write(i + " ");
    if (i == 7)
        break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for(int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

for(int i = 0; i < names.Length; i++)
    if (names[i] == "David")
        names[i] = "Sammy";

foreach(string name in names)
    Console.WriteLine(name);

// FizzBuzz challenge

/*
 * Consigna:
 * Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
 * Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
 * Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
 * Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
 */

// My solution
for(int i = 1; i <= 100; i++)
{
    bool isDivisibleByThree = i % 3 == 0;
    bool isDivisibleByFive = i % 5 == 0;

    if (isDivisibleByThree && isDivisibleByFive)
        Console.WriteLine($"{i} - FizzBuzz");
    else if (isDivisibleByThree)
        Console.WriteLine($"{i} - Fizz");
    else if (isDivisibleByFive)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine(i);
}

// Microsoft's solution
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}