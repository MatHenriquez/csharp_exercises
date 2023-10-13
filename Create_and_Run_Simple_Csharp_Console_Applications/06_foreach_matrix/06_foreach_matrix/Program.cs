// Declaración de una nueva matriz
//string[] fraudulentOrderIDs = new string[3];
// El operador new crea una nueva instancia de una matriz en la memoria del equipo que puede contener tres valores de cadena.
// El primer conjunto de corchetes [] simplemente indica al compilador que la variable denominada fraudulentOrderIDs será una matriz.
// El segundo conjunto de corchetes [3] indica el número de elementos que puede contener la matriz.
// El segundo conjunto de corchetes [3] indica el número de elementos que puede contener la matriz.

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";

// Inicialización de una matriz
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Propiedad Length de una matriz
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fradulent orders to process.");
