using System;
/*24.	Se ingresa una matriz de NxM componentes. La computadora indica el elemento mínimo de toda la matriz y las posiciones 
 * en que aparece. */
namespace _2do_trimestre_ejercicio_matriz_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0; int col = 0; int menor = 0;
            Console.WriteLine("Ingrese cantidad de filas");
            filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de columnas");
            col = Int32.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, col]; 

            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("Ingrese num de la fila {0} , columna {1}: ", cont + 1, cont2 + 1);
                    matriz[cont, cont2] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            //____________________IMPRIMIR TABLA____________________________
            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("{0,3}", matriz[cont, cont2]);
                }
                Console.WriteLine();
            }
            menor = matriz[filas - 1, col - 1];
            for (int cont = 0; cont <filas; cont++)
            {
                for (int cont2 = 0; cont2<col; cont2++)
                {
                    if (matriz[cont, cont2] < menor)
                    {
                        menor = matriz[cont, cont2];
                    }
                }
            }
                Console.WriteLine("El nro menor de toda la matriz es: " + menor);
            //_____________________POSICION______________________________________________

            for (int cont = 0; cont<filas; cont++)
            {
             
                for (int cont2 = 0; cont2<col; cont2++)
                {
                 
                    if (menor==matriz[cont, cont2])
                    {
                        Console.WriteLine("Aparece en la posicion fila: {0}, columna {1}",cont+1,cont2+1);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
