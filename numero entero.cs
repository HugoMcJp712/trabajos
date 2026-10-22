using System;

class Program
{
    // PASO 2: Función recursiva con acumulador para invertir el número
    // 'resultado' guarda el número invertido que se va formando en cada llamada
    static long Invertir(long n, long resultado = 0)
    {
        // Caso Base: Cuando n llega a 0, ya no quedan dígitos por procesar
        if (n == 0)
        {
            return resultado;
        }

        // Caso Recursivo:
        // - (n / 10): Le quita el último dígito al número actual.
        // - (resultado * 10 + n % 10): Toma el último dígito (n % 10) y lo agrega al acumulador.
        return Invertir(n / 10, resultado * 10 + n % 10);
    }

    // PASO 1: Punto de inicio del programa
    static void Main()
    {
        // Pedir al usuario que ingrese el número
        Console.Write("ingresa un numero positivo: ");
        long n = long.Parse(Console.ReadLine());

        // Validar que no sea negativo
        if (n < 0)
        {
            Console.WriteLine("el numero debe ser positivo.");
            return; // Sale del programa si es negativo
        }

        // CASO ESPECIAL: Si el usuario ingresa el número 0
        if (n == 0)
        {
            Console.WriteLine("numero invertido: 0");
            return;
        }

        // PASO 3: Llamar a la función e imprimir el resultado
        long numeroInvertido = Invertir(n);
        Console.WriteLine("numero invertido: " + numeroInvertido);
    }
}
