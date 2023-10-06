using System;

namespace numericOperations
{
    class Program
    {

        static void Main(string[] args)
        {
            // Adición de dos valores numéricos.

            int firstNumber = 12;
            int secondNumber = 7;

            Console.WriteLine(firstNumber + secondNumber); // '+' es el operador de adición. Ambos números se suman

            //Combinación de tipos de datos para forzar las conversiones implícitas de tipos

            string firstName = "Bob";
            int widgetsSold = 7;

            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets."); // '+' es ahora el operador de concatenación (sobrecarga del operador). 'widgetsSold' se convierte implícitamente en string y se concatena.

            // Caso de suma numérica y concatenación de cadenas.

            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // 'widgetsSold' y el literal 7 se concatenan, no se suman.

            // Adición de paréntesis para aclarar la intención al compilador.

            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // El símbolo de paréntesis () es otro operador sobrecargado. En este caso, forman el operador de orden de las operaciones. Ahora, 'widgetsSold' y 7 se suman.

            int sum = 7 + 5;        // + es el operador de suma
            int difference = 7 - 5; // - es el operador de resta
            int product = 7 * 5;    // * es el operador de multiplicación
            int quotient = 7 / 5;   // / es el operador de división ----> Queda 1 (uno) porque int no puede contener la parte decimal. Trunca el valor  su parte entera.

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);


            decimal decimalQuotient = 7.0m / 5;         // Guarda el valor exacto. 
            /*  
             * decimal decimalQuotient = 7 / 5.0m;      // Guarda el valor exacto. 
             * decimal decimalQuotient = 7.0m / 5.0m;   // Guarda el valor exacto. 
             * int decimalQuotient = 7 / 5.0m;          // Error.
             * int decimalQuotient = 7.0m / 5;          // Error.
             * int decimalQuotient = 7.0m / 5.0m;       // Error.
             * decimal decimalQuotient = 7 / 5;         // Guarda sólo el valor entero. 
             */
            Console.WriteLine($"Decimal quotient: {decimalQuotient}");


            // Incorporación de código para efectuar la división con datos decimales literales

            int first = 7;
            int second = 5;
            decimal myQuotient = (decimal)first / (decimal)second; // Esta conversión de datos que indica al compilador que trate temporalmente un valor como si fuera otro tipo de datos.
            Console.WriteLine(myQuotient);

            // Módulo

            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // 0
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); // 2 (redondea para arriba)

            // Orden de las operaciones

            /*
             * Parentheses (paréntesis) (lo que se encuentra dentro del paréntesis se realiza primero)
             * Exponents (exponentes)
             * Multiplication (multiplicación) y Division (división) (de izquierda a derecha)
             * Addition (suma) y Subtraction (resta) (de izquierda a derecha)
            */
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1); // 23
            Console.WriteLine(value2); // 35

            // Incremento y decremento de valores

            // Operador +=: suma y asigna el valor situado a la derecha del operador al valor situado a la izquierda del operador.
            int value = 0;      // value is now 0
            value = value + 5;  // value is now 5
            value += 5;         // value is now 10

            // El operador ++ incrementa el valor de la variable en 1
            value = value + 1;  // value is now 11
            value += 1;         // value is now 12
            value++;            // value is now 13

            // Estas mismas técnicas se pueden usar en restas, multiplicaciones y otras muchas operaciones. 
            // Los operadores como +=, -=, *=, ++ y -- se conocen como operadores de asignación compuesta porque realizan alguna operación además de asignar el resultado a la variable. El operador += se denomina específicamente operador de asignación de suma.

            int testValue = 1;
            Console.WriteLine("Initial value: " + testValue);       // 1

            testValue = testValue + 1;
            Console.WriteLine("First increment: " + testValue);     // 2

            testValue += 1;
            Console.WriteLine("Second increment: " + testValue);    // 3

            testValue++;
            Console.WriteLine("Third increment: " + testValue);     // 4

            testValue = testValue - 1;
            Console.WriteLine("First decrement: " + testValue);     // 3

            testValue -= 1;
            Console.WriteLine("Second decrement: " + testValue);    // 2

            testValue--;
            Console.WriteLine("Third decrement: " + testValue);     // 1

            // Colocación de los operadores de incremento y decremento

            // Uso del operador de incremento antes y después del valor
            int myValue = 1;
            myValue++;
            Console.WriteLine("First: " + myValue);         // 2
            Console.WriteLine($"Second: {myValue++}");      // 2 ---> Hay dos pasos en esta línea:
                                                            // 1. Se recupera el valor actual de la variable value y se usa en la operación de interpolación de cadenas.
                                                            // 2. Se incrementa el valor.
            Console.WriteLine("Third: " + myValue);         // 3
            Console.WriteLine("Fourth: " + (++myValue));    // 4 ---> Aquí, el orden de las operaciones cambia porque el operador ++ se coloca delante del operando value.
                                                            // 1. Se incrementa el valor.
                                                            // 2. Se recupera el nuevo valor incrementado de la variable value y se usa en la operación de cadena.

        }
    }
}