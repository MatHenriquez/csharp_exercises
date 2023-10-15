// Reglas para los nombres de variables locales.

/* 
 * Obligatorias:
 * Los nombres de variables pueden contener caracteres alfanuméricos y el carácter de subrayado. No se permiten caracteres especiales.
 * Los nombres de variables deben comenzar con una letra alfabética o un carácter de subrayado, no con un número.
 * Los nombres de variables no deben ser una palabra clave de C#. 
 * Los nombres de variables distinguen mayúsculas de minúsculas.
 * 
 * No Obligatorias:
 * Los nombres de variable deben usar “camel case”.
 * Los nombres de variables deben ser descriptivos y significativos en la aplicación.
 * Los nombres de variables deben ser una o varias palabras completas anexadas. No use contracciones.
 * Los nombres de variables no deben incluir el tipo de datos de la variable. 
 */

// Ejemplos válidos:
bool orderComplete; // Y no bool isComplete;
decimal orderAmount; // Sin contracciones y no decimal odrAmt;
string lastName; // Sin incluir el tipo de dato y no string strLastName;
char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer;

// Creación de comentarios de código efectivos.

// Un comentario de código es una instrucción del compilador para omitir todo lo que aparece después de los símbolos de comentario de código en la línea actual. Ej:
// This is a code comment!
// Es buena idea usar los comentarios para ideas de nivel superior y no agregar comentarios sobre cómo funciona una línea de código individual.

// Ejercicio:
string firstName = "Bob";
int widgetsPurchased = 7;
/* Testing a change to the message.
 * int widgetsSold = 7;
 * Console.WriteLine($"{firstName} sold {widgetsSold} widgets."); */ 
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

// Segundo Ejercicio:

// Ejemplos de comentarios innecesarios y excesivos.
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
// Get a random value that equates to ASCII letters A through E
int prefixValue = random.Next(65, 70);
// Convert the random value into a char, then a string
string prefix = Convert.ToChar(prefixValue).ToString();
// Create a random number, pad with zeroes
string suffix = random.Next(1, 1000).ToString("000");
// Combine the prefix and suffix together, then assign to current orderID
orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Ejemplo de un comentario único y bien hecho que debería ir al principio del código:

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

// Uso del espacio en blanco para facilitar la legibilidad del código

//El compilador de C# omite los espacios en blanco

//Ejemplo 1:
//Console
//.
//WriteLine
//(
//"Hello Example 1!"
//)
//;

// Ejemplo 2:
//string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Andan pero no son legibles.

// Ejemplo 3:

// Mal

//Random dice = new Random();
//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);
//int total = roll1 + roll2 + roll3;
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
//    if ((roll1 == roll2) && (roll2 == roll3)){
//        Console.WriteLine("You rolled triples!  +6 bonus to total!");
//        total += 6;
//    } else {
//        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//        total += 2;
//    }
//}

// Bien:
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}