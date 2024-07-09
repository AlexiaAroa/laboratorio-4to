using System;
namespace Proyecto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Se ingresan 10 números. La computadora muestra el valor máximo e indica la cantidad de veces que apareció y el número de orden en que fue ingresado.
            int[] V = new int[10];
            int C = 0, M;
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Ingrese numero({0})", a + 1);
                V[a] = int.Parse(Console.ReadLine());
            }
            M = V[0];
            Console.WriteLine("\n\n\n----------------------");
            for (int a = 0; a < 10; a++)
            {
                if (V[a] > M)
                {
                    M = V[a];
                }
            }
            Console.WriteLine("El {0} es el mayor y se repite en:\n", M);
            for (int a = 0; a < 10; a++)
            {
                if (V[a] == M)
                {
                    C++;
                    Console.WriteLine("El {0}º numero ingresado", a+1);
                }
            }
            Console.WriteLine("\nSe repite {0} veces", C);
            Console.ReadKey();
        }
    }
}
