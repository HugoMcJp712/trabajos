using System;

class program
{
    static int sumardigitos(int n)
    {
        if (n == 0)
            return 0;

        return n % 10 + sumardigitos(n / 10);
    }

    static void main()
    {
        Console.Write("ingreso numero:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("ingrese un numero positivo.");
            return;
        }

        Console.WriteLine("suma de digitos:" + sumardigitos(n));
    }
}