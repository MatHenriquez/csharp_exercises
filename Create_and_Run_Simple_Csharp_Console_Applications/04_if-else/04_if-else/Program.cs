/*
 * Usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Para calcular la puntuación, evaluará los valores obtenidos. Si la puntuación es mayor que un total arbitrario, se mostrará un mensaje
 * de éxito al usuario. Si la puntuación está por debajo del límite, se mostrará un mensaje de fracaso al usuario.
 * Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
 * Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
 * Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
 * Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
 * Si el jugador obtiene una puntuación de 7, gana un viaje.
 * De lo contrario, el jugador gana un gatito.
 */

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

//roll1 = 6;
//roll2 = 6;
//roll3 = 6;

int total = roll1  + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Expresiones booleanas

/*
 * string message = "The quick brown fox jumps over the lazy dog.";
 * bool result = message.Contains("dog");
 * Console.WriteLine(result);
 * if(message.Contains("fox"))
 * {
 * Console.WriteLine("What does the fox say?");
 * }
*/

// Dobles

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // Condición compuesta.
{

    // Triples
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    
}

//if(total >= 15) // Palabra clave if y expresión booleana entre paréntesis.
//{
//    Console.WriteLine("You win!");  // Bloque de código delimitado por llaves.
//}

//if(total < 15)
//{
//    Console.WriteLine("Sorry, you lose.");
//}

if(total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if(total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if(total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}