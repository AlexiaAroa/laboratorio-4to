using System;
/*30.Se ingresa una matriz de NxN componentes enteras. La computadora muestra los valores ubicados en la diagonal principal, 
 ordenados de mayor a menor. */

namespace _2do_trimestre_ejercicio_matriz_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, max;
            Console.Write("Ingrese cantidad de filas y columnas: ");
            a = int.Parse(Console.ReadLine());
            int[,] matriz = new int[a, a];
            for(int cont = 0; cont < a; cont++)
            {
                for(int cont2 = 0; cont2 < a; cont2++)
                {
                    Console.WriteLine("Fila {0}, Columna {1}: ", cont + 1, cont2 + 1);
                    matriz[cont, cont2] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("TABLA: ");
            for(int cont = 0; cont < a; cont++)
            {
                for(int cont2 = 0; cont2 < a; cont2++)
                {
                    Console.Write("{0,3} ",matriz[cont,cont2]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Estos son los numeros de la diagonal principal");
            for (int cont = 0; cont < a; cont++)
            {
                for (int cont2 = 0; cont2 < a; cont2++)
                {
                    if (cont == cont2)
                    {
                        Console.WriteLine(matriz[cont, cont2]);
                    }
                }
            }
            Console.WriteLine("Ordenados de mayor a menor");
            for (int cont = 0; cont < a; cont++)
            {
                for (int cont2 = 0; cont2 < a; cont2++)
                {
                    if (cont == cont2)
                    {
                        //Console.WriteLine(matriz[cont, cont2]);

                    }
                }
            }
            Console.ReadKey();
        } //fin main
    }
}
