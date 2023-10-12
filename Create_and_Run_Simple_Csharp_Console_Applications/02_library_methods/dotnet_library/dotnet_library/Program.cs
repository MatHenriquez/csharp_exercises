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

// Aunque un método devuelve un valor, podemos llamarlo sin usar el valor devuelto.
Console.WriteLine(dice.Next(1, 7));