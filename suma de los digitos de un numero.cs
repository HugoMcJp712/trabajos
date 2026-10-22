using System;

class Program
{
    // PASO 2: Función recursiva para sumar los dígitos del número
    static int SumarDigitos(int n)
    {
        // Caso Base: Cuando n llega a 0, ya no quedan dígitos por sumar
        if (n == 0)
        {
            return 0;
        }

        // Caso Recursivo:
        // - (n % 10): Obtiene el último dígito del número actual.
        // - SumarDigitos(n / 10): Elimina el último dígito y llama a la función con el resto del número.
        return (n % 10) + SumarDigitos(n / 10);
    }

    // PASO 1: Inicio del programa
    static void Main()
    {
        // Pedir el número al usuario
        Console.Write("ingreso numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número no sea negativo
        if (n < 0)
        {
            Console.WriteLine("ingrese un numero positivo.");
            return; // Termina la ejecución si es un número negativo
        }

        // PASO 3: Llamar a la función e imprimir el resultado final
        int resultado = SumarDigitos(n);
        Console.WriteLine("suma de digitos: " + resultado);
    }
}
