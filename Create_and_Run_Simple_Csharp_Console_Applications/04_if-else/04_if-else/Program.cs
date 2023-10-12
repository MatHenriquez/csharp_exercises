/*
 * Usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Para calcular la puntuación, evaluará los valores obtenidos. Si la puntuación es mayor que un total arbitrario, se mostrará un mensaje
 * de éxito al usuario. Si la puntuación está por debajo del límite, se mostrará un mensaje de fracaso al usuario.
 * Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
 * Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
 * Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego. De lo contrario, pierde.
 */

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1  + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if(total > 14) // Palabra clave if y expresión booleana entre paréntesis.
{
    Console.WriteLine("You win!");  // Bloque de código delimitado por llaves.
}

if(total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

// Expresiones booleanas

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");

Console.WriteLine(result);

if(message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}