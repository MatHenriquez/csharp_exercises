// Project 1

//Estas son las condiciones que el primer proyecto de codificación debe implementar:

//La solución debe incluir una iteración do-while o while.

//Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

//Dentro del bloque de iteración:

//La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
//La solución debe asegurarse de que la entrada es una representación válida de un entero.
//Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
//La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
//Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.

string? userInput;
int numericInput = 0;
bool isInt = false;
bool validEntry = false;

Console.WriteLine("Type a number between 5 and 10:");

do
{
    userInput = Console.ReadLine();
    isInt = int.TryParse(userInput, out numericInput);

    validEntry = isInt && (numericInput >= 5 && numericInput <= 10);

    if (validEntry)
        continue;        

    Console.WriteLine("Please, type a number between 5 and 10:");

} while (!validEntry);

Console.WriteLine("You typed a valid number.");

// Project 2

//Estas son las condiciones que el segundo proyecto de codificación debe implementar:

//La solución debe incluir una iteración do-while o while.

//Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

//Dentro del bloque de iteración:

//La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
//La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
//La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y finales.
//La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
//Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
//Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
