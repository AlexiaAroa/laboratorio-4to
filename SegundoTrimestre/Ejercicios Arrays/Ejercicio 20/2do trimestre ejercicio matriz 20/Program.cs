using System;
/*20.	Se ingresa una matriz de NxN componentes. La computadora calcula y 
        muestra:
a) La traza de la matriz (suma de los elementos de la diagonal principal)
b) La suma de los elementos de la otra diagonal 
*/

namespace _2do_trimestre_ejercicio_matriz_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int j = 0; int sumap = 0; int sumas = 0; //fila x           columna y          I think:v
            Console.Write("Ingrese nro de filas y col de componentes: ");
            i = Int32.Parse(Console.ReadLine());
            j = i;
            int[,] matriz = new int[i, j];
            for(int c = 0; c < i; c++)
            {
                for(int f=0; f < j; f++)
                {
                    Console.WriteLine("Ingrese nro para la fila {0}, columna {1}",c+1,f+1);
                    matriz[f, c] = Int32.Parse(Console.ReadLine());
                }
            }

            for(int c = 0; c < i; c++)
            {
                for (int f = 0; f < j; f++)
                {
                    Console.Write(" {0,1} ", matriz[f, c]);
                }
                    Console.WriteLine(); 
            }
        
             Console.Write("SUMA DE DIAGONAL PRINCIPAL: ");
            for(int c = 0; c < i; c++)
            {
                for(int f = 0; f < j; f++)
                {
                    if (c == f)
                    {
                        sumap = sumap + matriz[f, c];
                    }
                }
            }
            Console.WriteLine(sumap);

            Console.Write("SUMA DE LA OTRA DIAGONAL: ");
            for(int cont = 0; cont < i; cont++)
            {
                sumas = sumas + matriz[cont, (i-1)-cont];
            }
            

            Console.WriteLine(sumas);

            // 0,0    0,1    0,2   0,3  
            // 1,0    1,1    1,2   1,3
            // 2,0    2,1    2,2   3,3
            // 3,0    3,1    3,2   3,3
            Console.ReadKey();
        }
    }
}
