using System;

namespace numeroprimo;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse (Console.ReadLine());

        if (EsPrimo(numero))
        {
            Console.WriteLine("El número es primo.");
        }
        else
        {
            Console.WriteLine("El número no es primo.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
