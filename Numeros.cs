using System;
class Problem
{
    private static int n;

    static void Main()
    {
        Console.Write("Ingreso Numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("Ingreso Un Numero entre 0 y 20 ");
            return;
        }

        Console.WriteLine("Fibonacci:" + Factorial(n));
    }

    private static string Factorial(int n)
    {
        throw new NotImplementedException();
    }
}

