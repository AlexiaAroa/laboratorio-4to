using System;
namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            do
            {
                Console.WriteLine("Ingrese año");
                año = Int32.Parse(Console.ReadLine());
                if (año % 4 != 0 || año % 100 == 0 && año % 400 != 0)
                    Console.WriteLine("No es bisiesto");
                else
                    Console.WriteLine("Este año es bisiesto");
            } while (año % 4 != 0 || año % 100 == 0 && año % 400 != 0);
            Console.ReadKey();
        }
    }
}