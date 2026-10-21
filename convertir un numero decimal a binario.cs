using System;
class Program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        BinarioA(n / 2);
        Console.Write(n % 2);
    }

    static void Main(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }

        BinarioA(n / 2);
        Console.WriteLine(n % 2);
    }

    static void Main()
    {
        Console.Write("Ingrese un numero entero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Ingrese un numero no negativo.");
            return;
        }

        Console.Write("Binario:");

        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
            BinarioA(n);

            Console.WriteLine();
        }
    }











