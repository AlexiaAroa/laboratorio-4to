using System;
/*
 19.Se ingresan los 10 números ganadores de un sorteo. A continuación, se 
 ingresan números. La computadora indica si los números ingresados están entre 
 los sorteados y en qué posición. 
     */

namespace _2do_trimestre_ejercicio_array_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10]; int ac; 
            Console.WriteLine("Ingrese los nros ganadores del sorteo");
            for (int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("Ingrese nro {0}", cont + 1);
                vector[cont] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Ingrese nro: ");
            ac = Int32.Parse(Console.ReadLine());
                for (int cont = 0; cont < 10; cont++)
                {
                    if (vector[cont] == ac)
                    {
                        Console.WriteLine("El nro que usted ingreso está entre los ganadores");
                        Console.WriteLine("Posicion: {0}  || Nro: {1}", cont + 1, vector[cont]);
                    }
                }
            Console.ReadKey();
        } //fin main
    }
}
