// Literales

Console.WriteLine('b'); // Imprime el literal de tipo character b, que va entre comillas simples.
// Console.WriteLine('Hello, World!'); // Da error porque se intenta guardar un string en comillas simples.
Console.WriteLine(123); // Imprime el literal de tipo integer 123.
Console.WriteLine(0.25F); // Imprime el literal de tipo float 0.25. F (o f) se denomina 'sufijo literal'.
Console.WriteLine(2.625); // Imprime el literal de tipo double 2.625. Al no tener sufijo literal, es double por defecto.
Console.WriteLine(12.39816m); // Imprime el literal de tipo decimal 12.39816. m (o M) se denomina 'sufijo literal'.

// Literales de tipo booleano
Console.WriteLine(true);
Console.WriteLine(false);

string firstName; // Declaro mi variable firstName de tipo string.
firstName = "Bob"; // Le asigno un valor a mi variable. El '=' se conoce como 'operador de asignación' (operación 'set'). La asignación se produce de derecha a izquierda.
Console.WriteLine(firstName); // Imprimo en consola el valor almacenado en firstName (operación 'get').
firstName = "Liem"; // Asigno un nuevo valor a la variable.
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

/*
 * string lastName;
 * Console.WriteLine(lastName); // Error: la variable secondName no tiene un valor asignado.
 * string lastName = "Watson"; // Inicializo la variable (le asigno un valor en la misma línea donde la declaro).
 */

// Variables locales de tipo implícito
var message = "Hello, World!"; // La palabra clave 'var' indica al compilador de C# que el tipo de datos está implícito en el valor asignado. La variable DEBE inicializarse.
Console.WriteLine(message);