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