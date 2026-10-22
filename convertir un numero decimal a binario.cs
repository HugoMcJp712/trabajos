using System;

class Program
{
    // PASO 2: Función recursiva para convertir de decimal a binario
    static void BinarioA(int n)
    {
        // Caso Base: Cuando el número se reduce a 0 o 1, se imprime directamente.
        if (n < 2)
        {
            Console.Write(n);
            return; // Termina esta llamada para comenzar a regresar en la pila
        }

        // Caso Recursivo: 
        // Primero divide el número entre 2 para llegar hasta el bit más significativo (el de más a la izquierda).
        BinarioA(n / 2);

        // Al regresar de las llamadas recursivas, imprime el residuo (el bit actual).
        Console.Write(n % 2);
    }

    // PASO 1: Punto de entrada principal del programa
    static void Main()
    {
        // Pedir al usuario que ingrese un número
        Console.Write("Ingrese un numero entero: ");
        int n = int.Parse(Console.ReadLine());

        // Validar que no sea un número negativo
        if (n < 0)
        {
            Console.WriteLine("Ingrese un numero no negativo.");
            return; // Sale del programa
        }

        Console.Write("Binario: ");

        // CASO ESPECIAL: Si ingresan el número 0
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            // PASO 3: Llamar a la función recursiva
            BinarioA(n);
        }

        Console.WriteLine(); // Salto de línea final para ordenar la consola
    }
}








