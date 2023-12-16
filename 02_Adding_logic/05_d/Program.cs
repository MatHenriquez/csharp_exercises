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

using Microsoft.VisualBasic;

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

Console.WriteLine("Enter your role:");
string[] userRoles = { "Administrador", "Director", "Usuario" };
bool rolInputValid = false;
string? userRol;

do
{
    userRol = Console.ReadLine();

    foreach (string role in userRoles)
        if (role.ToLower() == userRol?.Trim().ToLower())
            rolInputValid = true;

    if(rolInputValid)
        continue;

    Console.WriteLine("Please, type one of the valid roles.");
} while (!rolInputValid);

Console.WriteLine($"Welcome, {userRol}!");

// Project 3

//Estas son las condiciones que el tercer proyecto de codificación debe implementar:

//La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:

//string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//La solución debe declarar una variable de enteros denominada periodLocation que se pueda usar para contener la ubicación del carácter de punto dentro de una cadena.

//La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz. La variable de cadena que procesará dentro de los bucles debe denominarse myString.

//En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer carácter de punto de la variable myString. La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún carácter de punto en la cadena, se devolverá un valor de -1.

//La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

//En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las cadenas que se procesan.

//En el bucle interno, la solución no debe mostrar el carácter de punto.

//En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información de cadena.

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;


foreach (string myString in myStrings)
{
        string copiedString = myString;
        periodLocation = copiedString.IndexOf(".");
    do
    {
        if (periodLocation == -1)
            Console.WriteLine(copiedString.TrimStart());

        else { 
            string mySubString = copiedString.Substring(0, periodLocation).TrimStart();
            Console.WriteLine(mySubString);

            copiedString = copiedString.Remove(0, periodLocation + 1).TrimStart();
            periodLocation = copiedString.IndexOf(".");

            if(periodLocation == -1)
                Console.WriteLine(copiedString);
        }
    } while (periodLocation > -1) ;
}