using System;

class Program
{
    // PASO 3: Definición del método recursivo para calcular el factorial
    static long Factorial(int n)
    {
        // PASO 3.1: Caso Base (Condición de parada de la recursividad)
        // El factorial de 0 es 1. Al llegar a 0, la función deja de llamarse a sí misma.
        if (n == 0)
        {
            return 1;
        }
        // PASO 3.2: Caso Recursivo
        // Multiplica el número actual 'n' por el factorial del número anterior (n - 1).
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main()
    {
        // PASO 1: Solicitar y leer la entrada del usuario
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        // PASO 2: Validar el rango permitido (entre 0 y 20)
        // Evita números negativos (que no tienen factorial) y mayores a 20 (para evitar desbordamiento de memoria).
        if (n < 0 || n > 20)
        {
            Console.WriteLine("Ingresa un numero entre el 0 y 20");
            return; // Termina la ejecución si el número no es válido
        }

        // PASO 4: Iniciar la llamada recursiva y obtener el resultado
        long resultado = Factorial(n);

        // PASO 5: Imprimir el resultado final en la consola
        Console.WriteLine("Factorial: " + resultado);
    }
}
