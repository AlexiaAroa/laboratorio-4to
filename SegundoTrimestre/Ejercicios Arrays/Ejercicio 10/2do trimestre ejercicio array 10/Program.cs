using System;
//10.Se ingresan 10 enteros. La computadora muestra aquellos ingresados con número de orden impar. 

namespace _2do_trimestre_ejercicio_array_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            for(int cont = 0; cont < 10; cont++)
            {
                Console.Write("Ingrese numero [{0}]: ",cont+1);
                vector[cont] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Nros de las posiciones impares: ");
            for (int cont = 0; cont < 10; cont++)
            {
                if ((cont + 1) % 2 != 0)
                {
                    Console.WriteLine("{0}. {1}", cont+1,vector[cont]);
                }
            }
            Console.ReadLine();
        } //fin main
    }
}
