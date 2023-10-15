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
string firstName; // Sin incluir el tipo de dato y no string strMyValue;
char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer;