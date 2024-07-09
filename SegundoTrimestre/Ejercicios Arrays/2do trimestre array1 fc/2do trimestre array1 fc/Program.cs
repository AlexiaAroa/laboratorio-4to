using System;
namespace Proyecto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Se ingresan 10 números. La computadora muestra aquellos que son múltiplos del último número ingresado
            int[] V = new int[10];
            int ult;
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Ingrese numero({0})", a + 1);
                V[a] = int.Parse(Console.ReadLine());
            }
            ult = V[9];
            Console.Clear();
            Console.WriteLine("los numeros multiplos de {0} son;", V[9]);
            for (int a = 0; a < 10; a++)
            {
                if (V[a] % ult == 0)
                {
                    Console.WriteLine("{0}", V[a]);
                }
            }
            Console.ReadKey();
        }
    }
}