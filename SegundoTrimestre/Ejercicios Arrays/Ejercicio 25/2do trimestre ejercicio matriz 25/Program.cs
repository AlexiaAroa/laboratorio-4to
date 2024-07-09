using System;
/*25.	Se ingresa una matriz de NxM componentes. La computadora muestra:
a) el promedio de la matriz
b) el promedio de cada fila
c) el promedio de cada columna 
*/
namespace _2do_trimestre_ejercicio_matriz_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = 0;int filas = 0; double suma = 0;
            Console.Write("Ingrese cantidad de filas ");
            filas = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de columnas: ");
            col = Int32.Parse(Console.ReadLine());
            double[,] Tabla = new double[filas, col];
            double[] VectorColumas = new double[col];
            double[] VectorFilas = new double[filas];
            // CARGAR DATOS
            for(int cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("Ingrese nro de la fila {0}, columa {1}:  ", cont + 1, cont2 + 1);
                    Tabla[cont, cont2] = double.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            //IMPRIMIR TABLA
            for(int cont = 0; cont < filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    Console.Write("{0,3}",Tabla[cont,cont2]);
                }
                Console.WriteLine();
            }
            //___________________________PROMEDIO TABLA COMPLETA_________________________
            for(int cont=0;cont< filas; cont++)
            {
                for(int cont2 = 0; cont2 < col; cont2++)
                {
                    suma = suma + Tabla[cont, cont2];
                }
            }
            Console.WriteLine("El promedio de la matriz es {0}",(suma/(filas*col)));

            //___________________________PROMEDIO DE LAS COLUMAS_________________________________
            Console.WriteLine("El promedio de las columas es: ");

            for(int cont2 = 0; cont2 < col; cont2++)
            {
                for(int cont = 0; cont < filas; cont++)
                {
                    VectorColumas[cont2]=VectorColumas[cont2] + Tabla[cont, cont2];
                }
                Console.Write("  {0,3}  ",VectorColumas[cont2]/filas);
            }         
            //_____________________________PROMEDIO DE CADA FILA ____________________________________
            Console.WriteLine();
            Console.WriteLine("El promedio de cada fila es: ");
            for (int cont = 0; cont < filas; cont++)
            {
                for (int cont2 = 0; cont2 < col; cont2++)
                {
                    VectorFilas[cont] = VectorFilas[cont] + Tabla[cont, cont2];
                }
                Console.WriteLine("{0,3}", VectorFilas[cont] / col);
            }
            Console.ReadKey();
        }
    }
}
