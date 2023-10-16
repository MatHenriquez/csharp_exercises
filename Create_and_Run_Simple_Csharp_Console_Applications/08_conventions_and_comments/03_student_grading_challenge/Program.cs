// Programa para llevar registro de calificaciones de 5 estudiantes.

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" }; // Listado de alumnos.

int examAssignments = 5;

// Obtengo las calificaciones de cada estudiante de manera aleatoria.
Random calification = new Random();
int[] sophiaScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] andrewScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] emmaScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] loganScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };

// Añado los créditos adicionales de los alumnos.

Console.WriteLine(sophiaScore[2]);