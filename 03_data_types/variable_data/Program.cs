namespace data_types;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Signed integer types:");

        Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");
    }
}