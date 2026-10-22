using System;

class Program
{
    // PASO 3.1: Método para comprobar si un número es PAR
    static bool espar(int n)
    {
        // Caso Base: El número 0 se considera PAR (devuelve true).
        if (n == 0)
            return true;

        // Caso Recursivo Cruzado: Si n > 0, un número es par si (n - 1) es IMPAR.
        // Llama al método 'esimpar'.
        return esimpar(n - 1);
    }

    // PASO 3.2: Método para comprobar si un número es IMPAR
    static bool esimpar(int n)
    {
        // Caso Base: El número 0 NO es impar (devuelve false).
        if (n == 0)
            return false;

        // Caso Recursivo Cruzado: Si n > 0, un número es impar si (n - 1) es PAR.
        // Llama al método 'espar'.
        return espar(n - 1);
    }

    static void Main()
    {
        // PASO 1: Solicitud e ingreso de datos
        Console.Write("ingrese numero:");
        int n = int.Parse(Console.ReadLine());

        // PASO 2: Validación del rango
        // Evita números negativos y evita valores demasiado grandes que causen un desbordamiento de pila (StackOverflowException).
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingrese un numero entre 0 y 1000.");
            return; // Finaliza el programa si el número está fuera de rango
        }

        // PASO 3: Evaluación del resultado mediante la recursividad mutua
        if (espar(n))
            Console.WriteLine("el numero es par.");
        else
            Console.WriteLine("el numero es impar.");
    }
}
