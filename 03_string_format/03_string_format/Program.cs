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