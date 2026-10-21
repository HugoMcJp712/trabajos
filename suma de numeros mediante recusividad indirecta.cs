using System;
class program
{
    static int sumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + sumaB(n - 1);
    }

    static int sumaB(int n)
    {
        if (n <= 0)
            return 0;

        return sumaA(n - 1);
    }

    static void Main()
    {
        Console.Write("ingresa un numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingresa un numero entre 0 y 1000.");
            return;
        }

        Console.WriteLine("la suma es:" + sumaA(n));
    }
}
