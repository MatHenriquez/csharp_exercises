// My solution
int result = new Random().Next(0, 2);
Console.WriteLine($"{(result == 1 ? "heads" : "tails")}");

// Microsoft's Solution
Random coin = new Random();
int flip = coin.Next();
Console.WriteLine((flip == 0) ? "heads" : "tails");

