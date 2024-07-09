using System;
//15.Cargar un array de m números enteros decir cual es el mayor y donde esta.
namespace _2do_trimestre_ejercicio_array_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; int cont = 0; int m = 0; int cont2 = 0;
            Console.Write("Ingrese tamaño del vector: ");
            i = Int32.Parse(Console.ReadLine());
            int[] vector = new int[i];
            for (cont = 0; cont < i; cont++)
            {
                Console.Write("Ingrese nro {0}: ", cont + 1);
                vector[cont] = Int32.Parse(Console.ReadLine());
            }
            for (cont = 0; cont < i; cont++)
            {
                if (vector[cont] > m)
                {
                    m = vector[cont];
                    cont2 = cont;
                }
            }
            Console.WriteLine("El nro mayor es {0} y esta en la posicion {1}",m,cont2+1);
            Console.ReadKey();
        }//fin main
    }
}
