using System;
//12.Escribir funciones que reciban un arreglo de 10 números enteros y devuelvan
//el mayor valor,   LISTO
//el menor valor,   LISTO
//el valor medio    LISTO
//la suma de todos los valores positivos. LISTO
namespace _2do_trimestre_ejercicio_array_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10]; int mayor = 0; int menor = 0; int medio = 0 ; int suma=0;
            //INGRESAR NUMEROS
            for(int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("Ingrese nro {0}: ", cont + 1);
                vector[cont] = int.Parse(Console.ReadLine());
            }
            //VALOR MAX
            for(int cont = 0; cont < 10; cont++)
            {
                if (vector[cont] > mayor)
                {
                    mayor = vector[cont];
                }
            }
            Console.WriteLine("El valor maximo es: {0}", mayor); Console.WriteLine();
            //VALOR MIN
            for(int cont = 9; cont >= 0; cont--)
            {
                if (vector[cont] < menor)
                {
                    menor = vector[cont];
                }
            }
            Console.WriteLine("El valor minimo es: {0}", menor); Console.WriteLine();

            //SUMA DE LOS VALORES POSITIVOS
            for(int cont=0; cont < 10; cont++)
            {
                if (vector[cont] > 0)
                {
                    suma = suma + vector[cont];
                }
            }
            Console.WriteLine("La suma de los valores positivos es {0}", suma); Console.WriteLine();
            medio = vector[4];
            Console.WriteLine("El numero del medio es: {0}", medio);
            Console.ReadKey();
        }
    }
}
