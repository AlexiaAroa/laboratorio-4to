using System;
namespace Ejercicio7bienhecho
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 0, cont2, a = 1;
            Console.WriteLine("Ingrese numero");
            num = Int32.Parse(Console.ReadLine());
            cont2 = num;
            while (cont <= cont2)
            {
                cont++;
                a = a * cont;
                if (cont == cont2)
                    Console.WriteLine("El factorial es "+a);
            }
            Console.ReadKey();
        }
    }
}