using System;

class Program
{
    // PASO 2: Función recursiva para calcular el valor de Fibonacci
    static int Fibonacci(int n)
    {
        // Caso Base: Si n es 0 o 1, devuelve el mismo número (Fibonacci(0)=0, Fibonacci(1)=1)
        if (n <= 1)
        {
            return n;
        }
        // Caso Recursivo: Suma los dos valores anteriores de la serie
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    // PASO 1: Inicio del programa
    static void Main()
    {
        // Pedir la posición deseada al usuario
        Console.Write("Ingrese la posicion: ");
        int n = int.Parse(Console.ReadLine());

        // Validar el rango permitido (entre 0 y 40)
        // Se limita a 40 porque con números más grandes la recursividad se vuelve muy lenta
        if (n < 0 || n > 40)
        {
            Console.WriteLine("Por favor ingrese un número entre 0 y 40.");
            return; // Termina la ejecución si está fuera de rango
        }

        // PASO 3: Llamar a la función e imprimir el resultado
        int resultado = Fibonacci(n);
        Console.WriteLine("Serie Fibonacci: " + resultado);
    }
}
