using System;
class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingrese la posicion: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 40)
        {
            Console.WriteLine("Por favor ingrese un número entre 0 y 40.");
            return;
        }
        Console.WriteLine("Serie Fibonacci: " + Fibonacci(n));
    }
}
