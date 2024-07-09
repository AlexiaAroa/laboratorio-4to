using System;
/*21.	Se ingresa una matriz de NxM componentes. La computadora indica la 
 cantidad de ceros que contiene. */
namespace _2do_trimestre_ejercicio_matriz_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0; int col = 0; int cant = 0;
            Console.WriteLine("Ingrese cantidad de filas");
            filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columnas");
            col = Int32.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, col];
            //INGRESAR VALORES
            for (int cont = 0; cont < col; cont++)
            {
                for (int cont2 = 0; cont2 < filas; cont2++)
                {
                    Console.Write("Ingrese nro para la fila {0}, columna {1}:  ", cont + 1, cont2 + 1);
                    matriz[cont, cont2] = Int32.Parse(Console.ReadLine());
                }
            }
            //VERIFICAR CEROS
            for (int cont = 0; cont < col; cont++)
            {
                for(int cont2 = 0; cont2 < filas; cont2++)
                {
                    if (matriz[cont,cont2] == 0)
                    {
                        cant++;
                    }
                }
            }
            Console.WriteLine("Contiene {0}  ceros ",cant);
            Console.ReadKey();
        }
    }
}
