using System;

class Program
{
    // PASO 2: Método A de la recursividad mutua
    // Suma el valor actual 'n' y le pasa el turno a sumaB
    static int sumaA(int n)
    {
        // Caso Base: Si el número es menor o igual a 0, se detiene la recursividad
        if (n <= 0)
        {
            return 0;
        }

        // Caso Recursivo: Suma 'n' y llama a sumaB con (n - 1)
        return n + sumaB(n - 1);
    }

    // PASO 3: Método B de la recursividad mutua
    // Omitirá el número actual 'n' y le devolverá el turno a sumaA
    static int sumaB(int n)
    {
        // Caso Base: Si el número es menor o igual a 0, se detiene la recursividad
        if (n <= 0)
        {
            return 0;
        }

        // Caso Recursivo: NO suma 'n' (se lo salta) y llama a sumaA con (n - 1)
        return sumaA(n - 1);
    }

    // PASO 1: Inicio del programa
    static void Main()
    {
        // Pedir el número al usuario
        Console.Write("ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validar el rango de entrada
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingresa un numero entre 0 y 1000.");
            return; // Termina el programa si no cumple la regla
        }

        // PASO 4: Llamar a la función principal e imprimir el resultado
        int resultado = sumaA(n);
        Console.WriteLine("la suma es: " + resultado);
    }
}
