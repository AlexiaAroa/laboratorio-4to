using System;
/*29.	Se ingresan un número entero A y una matriz de NxM componentes enteras. La computadora muestra los múltiplos de A 
 * presentes en la matriz, ordenados de menor a mayor. */
namespace _2do_trimestre_ejercicio_matriz_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0; int aux = 0; int A = 0; int filas = 0;int col = 0;
            Console.WriteLine("Ingrese numero: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de filas: ");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columas: ");
            col = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, col];

            for (cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    matriz[cont, cont2] = int.Parse(Console.ReadLine());
                }
            }

            for (cont = 0; cont < filas; cont++)
            {
                for(cont)
            }
          
            Console.ReadKey();
        }//fin main
    }
}

/*
   //ORDENAR VECTOR
            for (cont = 0; cont < 10; cont++)
            {
                for(int cont2=cont+1; cont2 < 10-1; cont2++)
                {
                 if (vector[cont] > vector[cont2])
                {
                        aux = vector[cont];
                        vector[cont] = vector[cont2];
                        vector[cont2] = aux;
                    }
                }
            }
            for (cont = 0; cont < 10; cont++)
            {
                Console.WriteLine(vector[cont]);
            }
     */
