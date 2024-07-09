using System;
//9.Se ingresan 10 enteros. La computadora muestra, a continuación, aquellos que son pares
namespace _2do_trimestre_ejercicio_array_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10]; bool h = true;
            try
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    Console.Write("Ingrese numero [{0}]: ", cont + 1);
                    vector[cont] = Int32.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR");
                h = false;
            }
            if (h == true)
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    if (vector[cont] % 2 == 0)
                    {
                        Console.WriteLine("El nro {0} es par", vector[cont]);
                    }
                }
            }
            Console.ReadKey();
        } //fin main
    }
}
