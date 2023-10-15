// Desafío de código: aplicación de directrices de estilo para mejorar la legibilidad

// Realice mejoras en el código y aumente su legibilidad con las técnicas que ha aprendido en este módulo.

/*
 * string str = "The quick brown fox jumps over the lazy dog.";
 * // convert the message into a char array
 * char[] charMessage = str.ToCharArray();
 * // Reverse the chars
 * Array.Reverse(charMessage);
 * int x = 0;
 * // count the o's
 * foreach (char i in charMessage) { if (i == 'o') { x++; } }
 * // convert it back to a string
 * string new_message = new String(charMessage);
 * // print it out
 * Console.WriteLine(new_message);
 * Console.WriteLine($"'o' appears {x} times.");
 */

// This code inverts a string and counts the number of times the character 'o' appears in it.

string message = "The quick brown fox jumps over the lazy dog";

char[] splitedMessage = message.ToCharArray();
Array.Reverse(splitedMessage);

int countOfO = 0;

foreach(char character in splitedMessage)
{
    if(character == 'o')
    {
        countOfO++;
    }
}

string newMessage = new string(splitedMessage);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {countOfO} times.");