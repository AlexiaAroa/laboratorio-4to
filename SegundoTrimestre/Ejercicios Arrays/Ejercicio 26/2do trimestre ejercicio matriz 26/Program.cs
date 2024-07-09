using System;
//26.Se ingresan dos matrices de NxM componentes enteras. La computadora las suma y muestra la matriz resultante. 

namespace _2do_trimestre_ejercicio_matriz_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = 0;int filas = 0;
            Console.WriteLine("Ingrese cantidad de filas");
            filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columas");
            col = Int32.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, col];
            int[,] matriz2 = new int[filas, col];
            int[,] matriz3 = new int[filas, col];
            Console.WriteLine("Ingrese valores de la MATRIZ 1: ");
            for(int cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("Fila {0}, columa {1}: ", cont + 1, cont2 + 1);
                    matriz[cont, cont2] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese valores de la MATRIZ 2: ");
            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("Fila {0}, columa{1}: ", cont + 1, cont2 + 1);
                    matriz2[cont, cont2] = Int32.Parse(Console.ReadLine());
                }
            }
            //________________________SUMAR______________________________
            for(int cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    matriz3[cont, cont2] = matriz[cont, cont2] + matriz2[cont, cont2];
                }
            }
            Console.Clear();
            //_______________________IMPRIMIR_________________________
            Console.WriteLine("MATRIZ 1");
            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("{0,3}", matriz[cont, cont2]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine("MATRIZ 2");
            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("{0,3}", matriz2[cont, cont2]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine("La matriz resultante es: ");
            for(int cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("{0,3}",matriz3[cont,cont2]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        } //fin main
    }
}
