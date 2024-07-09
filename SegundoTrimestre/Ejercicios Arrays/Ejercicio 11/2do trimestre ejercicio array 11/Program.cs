using System;
//11.Se ingresan 10 enteros. La computadora muestra la suma de los ingresados primero y último, del segundo y el penúltimo, y así sucesivamente. 
namespace _2do_trimestre_ejercicio_array_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10]; int suma; int cont2=9;
            for(int cont = 0; cont < 10; cont++)
            {
                Console.Write("Ingrese nro {0}: ",cont+1);
                vector[cont] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int cont = 0; cont < 5; cont++)
            {
                suma = vector[cont] + vector[cont2];
                Console.WriteLine("La suma entre {0} y {1} es {2}", vector[cont],vector[cont2],suma);
                cont2--;
            }
            Console.ReadKey();
        } //fin main
    }
}
