// Secuencia de caracteres de escape.
Console.WriteLine("Hello\nWorld!"); // La secuencia \n agregará una nueva línea.
Console.WriteLine("Hello\tWorld!"); // La secuencia \t agregará una tabulación.
Console.WriteLine("Hello \"World\"!"); // La secuencia \" agregará comillas dobles.
Console.WriteLine("c:\\source\\repos"); // La secuencia \\ agregará una barra invertida.

// Ejemplo de formato completo.
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Literal de cadena textual.
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)"); // Se crea con la directiva '@'. Se conservan todos los espacios en blancos y varacteres sin utilizar una secuencia de escape.
Console.WriteLine(@"c:\invoices");

// Caracteres de escape Unicode

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // La secuencia u seguido de cuatro caractes que representes un caracter Unicode (UTF-16), genera un caracter codificado.

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


// Concatenación de strings.

// Concatenación de una cadena de literales y una variable.
string firstName = "Bob";
string message = "Hello " + firstName; // El operador de concatenación de strings (+) anexa un string al final de otro.
Console.WriteLine(message);

// Concatenación de varias variables y cadenas de literales.
string greeting = "Hello";
string greetingMessage = greeting + " " + firstName + "!";
Console.WriteLine(greetingMessage);

// Interpolación de cadenas.
string interpolatedMessage = $"{greeting} {firstName}!"; // La acdena literal se convierte en plantilla cuando tiene como prefijo el caracter '$'. Una expresión de interpolación se indica con un símbolo de llave de apertura y cierre '{}'.
Console.WriteLine(interpolatedMessage);

int version = 11;
string updateText = "Update to Windows";
string consoleMessage = $"{updateText} {version}";

Console.WriteLine(consoleMessage);

// Evitar las variables intermedias
/* int version = 11;
 * string updateText = "Update to Windows";
 * Console.WriteLine($"{updateText} {version}!");
*/

// Combinación de los literales textuales y la interpolación de cadenas

string projectName = "First-Project";
Console.Write($@"C:\Output\{projectName}\Data");

// Desafío

/*
 * Lograr el siguiente Output:
 * View English output:
 *     c:\Exercise\ACME\data.txt
 *
 * Посмотреть русский вывод:
 *     c:\Exercise\ACME\ru-RU\data.txt
 *     
 *     Utilizando las variables dadas.
*/

//Resolución:
string myProjectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\Exercise\{myProjectName}\data.txt");

Console.WriteLine($"\n{russianMessage}:\n\tc:\\Exercise\\{myProjectName}\\ru-RU\\data.txt");