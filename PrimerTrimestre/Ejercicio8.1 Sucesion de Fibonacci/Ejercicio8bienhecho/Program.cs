using System;
namespace Ejercicio8bienhecho
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, cont = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (cont <= 7)
            {
                c = b + a;
                a = b;
                b = c;
                Console.WriteLine(c);
                cont++;
            }
            Console.ReadKey();
        }
    }
}