using System;

class Program
{
    // PASO 2: Método A de la recursividad mutua
    static void CuentaA(int n)
    {
        // Caso Base: Si el número es menor a 0, se detiene la cuenta
        if (n < 0)
        {
            return;
        }

        // Imprime el valor actual etiquetado con 'A'
        Console.WriteLine("A:" + n);

        // Caso Recursivo: Llama al método B restándole 1 al número
        CuentaB(n - 1);
    }

    // PASO 3: Método B de la recursividad mutua
    static void CuentaB(int n)
    {
        // Caso Base: Si el número es menor a 0, se detiene la cuenta
        if (n < 0)
        {
            return;
        }

        // Imprime el valor actual etiquetado con 'B'
        Console.WriteLine("B:" + n);

        // Caso Recursivo: Llama de vuelta al método A restándole 1 al número
        CuentaA(n - 1);
    }

    // PASO 1: Punto de inicio del programa
    static void Main()
    {
        // Pedir al usuario que ingrese un número inicial
        Console.Write("ingresa el numero inicial:");
        int n = int.Parse(Console.ReadLine());

        // Validar que el número esté entre 0 y 1000
        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingreso el numero entre 0 y 1000.");
            return; // Termina el programa si no cumple la regla
        }

        // Iniciar la cuenta regresiva desde el método A
        CuentaA(n);
    }
}
