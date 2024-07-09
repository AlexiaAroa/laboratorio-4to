using System;
/*2.Se ingresan 10 números. La computadora muestra el valor máximo e indica la 
 cantidad de veces que apareció y el número de orden en que fue ingresado. */
namespace _2do_trimestre_ejercicio_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 10;  int [] vector = new int [cantidad]; string valor = ""; int max = 0; int veces=0; bool hola = true;
            try
            {
                for (int n = 0; n < cantidad; n++)
                {
                    Console.Write("Ingrese nro [{0}]  ", n + 1);
                    valor = Console.ReadLine();
                    vector[n] = Convert.ToInt32(valor);
                }
            } //fin try
            catch (FormatException)
            {
                Console.WriteLine("ERROR! Cadena de entrada no compatible");
                hola = false;
                Console.ReadKey();
            }
            //Imprimir MAXIMO 
            if (hola == true)
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    if (vector[cont] > max)
                    {
                        max = vector[cont];
                    }
                }
                Console.WriteLine("El valor maximo es: {0}", max);

                for (int cont = 0; cont < 10; cont++)
                {
                    if (vector[cont] == max)
                    {
                        veces++;
                        //     nrodeorden = cont;
                        Console.WriteLine("El valor maximo se repite en la posicion {0}", cont + 1);
                    }
                }
                Console.WriteLine("El valor maximo aparecio {0} veces", veces);
                Console.ReadKey();
            }//fin comparacion bool
        } //fin main
    }
}
