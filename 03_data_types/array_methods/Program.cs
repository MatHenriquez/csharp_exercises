string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("String methods...");
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

Console.WriteLine("");
valueArray = value.ToCharArray();
Array.Reverse(valueArray);
result = String.Join(",", valueArray);
Console.WriteLine(result);

Console.WriteLine("");
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine("");
Console.WriteLine("---- CHALLENGE ----");

// Invert the characters of each word in the pangram
// Expected output: ehT kciuq nworb xof spmuj revo eht yzal god
string pangram = "The quick brown fox jumps over the lazy dog";

// My solution
Console.WriteLine("My solution...");
string[] pangramWords = pangram.Split(" ");
foreach (string word in pangramWords)
{
    char[] currentWordArray = word.ToCharArray();
    Array.Reverse(currentWordArray);
    string currentWordInverted = String.Join("", currentWordArray);
    Console.Write($"{currentWordInverted} ");
}

// My solution
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Microfot's solution...");

pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
result = String.Join(" ", newMessage);
Console.WriteLine(result);

// Second challenge
Console.WriteLine("");
Console.WriteLine("---- SECOND CHALLENGE ----");

// Expected output:
//A345
//B123
//B177
//B179
//C15     - Error
//C234
//C235
//G3003   - Error
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// My solution
Console.WriteLine("");
Console.WriteLine("My solution...");

byte expectedLength = 4;
string[] orders = orderStream.Split(",");

foreach (string order in orders)
{
    if (order.Length != expectedLength)
        Console.WriteLine($"{order}\t\t - Error");

    else
        Console.WriteLine(order);
}