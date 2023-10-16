// Programa para llevar registro de calificaciones de 5 estudiantes.
Random calification = new Random();

// Obtengo las calificaciones de cada estudiante de manera aleatoria.
int[] student1 = { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] student2 = { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] student3 = { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] student4 = { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] student5 = { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };

Console.WriteLine(student1[0]);