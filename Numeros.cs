using System;

class Problem
{
    // PASO 2: Función recursiva para calcular el número de Fibonacci
    static int Fibonacci(int n)
    {
        // Caso base 1: Si n es 0, el resultado es 0
        if (n == 0)
        {
            return 0;
        }
        // Caso base 2: Si n es 1, el resultado es 1
        else if (n == 1)
        {
            return 1;
        }
        // Caso recursivo: Suma los dos números anteriores de la serie
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void Main()
    {
        // PASO 1: Pedir al usuario que ingrese un número
        Console.Write("Ingreso Numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número esté entre 0 y 20
        if (n < 0 || n > 20)
        {
            Console.WriteLine("Ingreso Un Numero entre 0 y 20");
            return; // Termina el programa si no cumple la regla
        }

        // PASO 3: Llamar a la función e imprimir el resultado
        int resultado = Fibonacci(n);
        Console.WriteLine("Fibonacci: " + resultado);
    }
}
