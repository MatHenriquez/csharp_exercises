// See https:/// Adición de dos valores numéricos.

int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine(firstNumber + secondNumber); // '+' es el operador de adición. Ambos números se suman

//Combinación de tipos de datos para forzar las conversiones implícitas de tipos

string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets."); // '+' es ahora el operador de concatenación (sobrecarga del operador). 'widgetsSold' se convierte implícitamente en string y se concatena.

// Caso de suma numérica y concatenación de cadenas.

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // 'widgetsSold' y el literal 7 se concatenan, no se suman.

// Adición de paréntesis para aclarar la intención al compilador.

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // El símbolo de paréntesis () es otro operador sobrecargado. En este caso, forman el operador de orden de las operaciones. Ahora, 'widgetsSold' y 7 se suman.

int sum = 7 + 5;        // + es el operador de suma
int difference = 7 - 5; // - es el operador de resta
int product = 7 * 5;    // * es el operador de multiplicación
int quotient = 7 / 5;   // / es el operador de división ----> Queda 1 (uno) porque int no puede contener la parte decimal. Trunca el valor  su parte entera.

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);


decimal decimalQuotient = 7.0m / 5;         // Guarda el valor exacto. 
/*  
 * decimal decimalQuotient = 7 / 5.0m;      // Guarda el valor exacto. 
 * decimal decimalQuotient = 7.0m / 5.0m;   // Guarda el valor exacto. 
 * int decimalQuotient = 7 / 5.0m;          // Error.
 * int decimalQuotient = 7.0m / 5;          // Error.
 * int decimalQuotient = 7.0m / 5.0m;       // Error.
 * decimal decimalQuotient = 7 / 5;         // Guarda sólo el valor entero. 
 */
Console.WriteLine($"Decimal quotient: {decimalQuotient}");