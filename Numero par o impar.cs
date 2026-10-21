using System;

class program
{
    static bool espar(int n)
    {
        if (n == 0)
            return true;

        return esimpar(n - 1);
    }

    static bool esimpar(int n)
    {
        if (n == 0)
            return false;

        return espar(n - 1);
    }

    static void main()
    {
        Console.Write("ingrese numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingrese un numero entre 0 y 1000.");
            return;
        }

        if (espar(n))
            Console.WriteLine("el numero es par.");
        else
            Console.WriteLine("el numero es impar.");
    }
}



