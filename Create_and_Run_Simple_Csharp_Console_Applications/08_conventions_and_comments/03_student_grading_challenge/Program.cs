/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

// Programa para llevar registro de calificaciones de 5 estudiantes.

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" }; // Listado de alumnos.

int examAssignments = 5;

// Obtengo las calificaciones de cada estudiante de manera aleatoria.
Random calification = new Random();
int[] sophiaScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] andrewScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] emmaScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };
int[] loganScore = new int[] { calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101), calification.Next(0, 101) };

Console.WriteLine(sophiaScore[2]); // Impresión auxiliar