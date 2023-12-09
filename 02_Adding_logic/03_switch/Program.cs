string fruit = "banana";

switch (fruit) // Match expression
{
    case "apple":   // Case pattern
        Console.WriteLine($"App will display information for  apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}

int employeeLevel = 200;
string employeeName = "John Smith";

string title =  "";

switch (employeeLevel)
{
    case 50: // Dos etiquetas a la misma sección Switch.
    case 100:
        title = "Junior Associate";
        break;

    case 200:
        title = "Senior Associate";
        break;

    case 300:
        title = "Manager";
        break;

    case 400:
        title = "Senior Manager";
        break;

    default: // Se evalúa al último, sin importar dónde se escriba.
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");