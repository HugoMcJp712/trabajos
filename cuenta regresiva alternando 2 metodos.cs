using System;
class program
{
    static void cuentaA(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("A:" + n);
        cuentaB(n - 1);
    }

    private static void cuentaB(int v)
    {
        throw new NotImplementedException();
    }

    static void CuentaB(int n)
    {
        if (n < 0)
            return;

        Console.WriteLine("B:" + n);
        cuentaA(n - 1);
    }

    static void Main()
    {
        Console.Write("ingresa el numero inicial:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 1000)
        {
            Console.WriteLine("ingreso el numero entre 0 y 1000.");
            return;
        }

        cuentaA(n);
    }
}
     