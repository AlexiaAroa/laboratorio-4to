using System;
/*23.Se ingresa una matriz de NxM componentes. La computadora indica el valor
  máximo de cada columna. */

namespace _2do_trimestre_ejercicio_matriz_23
{
    class Program
    {
        static void Main(string[] args) 
        { 
            int filas = 0; int col = 0; 
            Console.WriteLine("Ingrese cantidad de filas");
            filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columnas");
            col = Int32.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, col];
            int[] vector = new int[col];

            for(int cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("Ingrese num de la fila {0} , columna {1}: ",cont+1,cont2+1);
                    matriz[cont, cont2] = Int32.Parse(Console.ReadLine());
                }
            }
            //___________COMPARACION______________________________
            for (int cont = 0; cont < filas; cont++)
            {
                vector[cont] = matriz[0, cont];

                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    if (matriz[cont2, cont] > vector[cont])
                    {
                        vector[cont] = matriz[cont2, cont];
                    }
                }
            }
            Console.Clear();
            //IMPRIMIR TABLA
            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("{0,3}", matriz[cont, cont2]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Los valores maximos de cada columna son:");
            for (int cont = 0; cont < filas; cont++)
            {
                Console.Write("{0,3}", vector[cont]);
            }
            Console.ReadKey();
        }
    }
}
