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