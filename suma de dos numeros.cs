using System;

class Program
{
    // PASO 2: Función recursiva para calcular la potencia
    static long Potencia(int baseNum, int exponente)
    {
        // Caso Base: Todo número elevado a la potencia 0 es igual a 1
        // Aquí se detienen las llamadas recursivas
        if (exponente == 0)
        {
            return 1;
        }

        // Caso Recursivo:
        // Multiplica la base por la llamada a la función reduciendo el exponente en 1
        return baseNum * Potencia(baseNum, exponente - 1);
    }

    // PASO 1: Inicio del programa
    static void Main()
    {
        // Pedir la base al usuario
        Console.WriteLine("Ingresa la Base");
        int baseNum = int.Parse(Console.ReadLine());

        // Pedir el exponente al usuario
        Console.WriteLine("Ingresa el Exponente (0 a 30): ");
        int exponente = int.Parse(Console.ReadLine());

        // Validar que el exponente sea positivo y no mayor a 30
        // Esto evita errores con exponentes negativos y previene desbordamiento de memoria (overflow)
        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente fuera de rango: ");
            return; // Termina la ejecución si el exponente no es válido
        }

        // PASO 3: Llamar a la función e imprimir el resultado
        long resultado = Potencia(baseNum, exponente);
        Console.WriteLine("Resultado: " + resultado);
    }
}
