Random dice = new Random(); // Generador de números aleatorios. dice es un objeto, una instancia de una clase (Random).
int roll = dice.Next(1, 7); // Obtengo un número del 1 al 6.
Console.WriteLine(roll);    // Muestro el número obtenido.

// Métodos con estado y sin estado

// Los métodos sin estado se implementan para poder funcionar sin hacer referencia a los valores que ya están almacenados en la memoria y sin cambiarlos. Los métodos sin estado también se conocen como métodos estáticos.
// Por ejemplo: el método Console.WriteLine(). 

// los métodos con estado se compilan de forma que dependen de los valores almacenados en memoria por líneas anteriores de código que ya se han ejecutado. O bien modifican el estado de la aplicación actualizando valores o almacenando nuevos valores en la memoria. También se conocen como métodos de instancia.

// Una sola clase puede admitir métodos con y sin estado. Sin embargo, cuando necesite llamar a métodos con estado, debe crear primero una instancia de la clase para que el método pueda tener acceso al estado.

// Valores devueltos

// Algunos métodos no devuelven valores cuando finalizan. Se hace referencia a ellos como métodos nulos (void).
// Otros métodos están diseñados para devolver un valor al finalizar.

// Aunque un método devuelve un valor, podemos llamarlo sin usar el valor devuelto. Ej:
Console.WriteLine(dice.Next(1, 7));

// Parámetros de entrada

/*
 * La información que consume un método se conoce como parámetro. Un método puede usar uno o varios parámetros para realizar su tarea o ninguno en absoluto.
 * Los términos "parámetro" y "argumento" se suelen usar indistintamente. Sin embargo, "parámetro" hace referencia a la variable que se usa dentro del método. El "argumento" es el valor que se pasa cuando se llama al método.
 */

// Métodos sobrecargados

// Muchos métodos de la biblioteca de clases .NET tienen firmas de método sobrecargadas. Entre otras cosas, esto nos permite llamar al método con o sin parámetros. Ej:
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Console.WriteLine("Presione una tecla para seguir viendo la info");
Console.ReadKey();
Console.Clear();

// Versiones sobrecargadas del método Random.Next()
int roll1 = dice.Next();        // No se establece un límite superior e inferior. El método devolverá valores entre 0 y 2,147,483,647 (valor máximo que int puede almacenar).
int roll2 = dice.Next(101);     // Esta versión especifica el valor máximo como límite superior. Dará un valor aleatorio entre 0 y 100.
int roll3 = dice.Next(50, 101); // Especifica el valor mínimo y el valor máximo. Da un valor aleatorio entre 50 y 100.

Console.WriteLine($"First roll: {roll1}"); 
Console.WriteLine($"Second roll: {roll2}"); 
Console.WriteLine($"Third roll: {roll3}");


