using System;
/*5.Imprimir y sumar los elementos que ocupan las posiciones pares de una lista 
 numérica.*/

namespace _2do_trimestre_ejercicio_array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10]; string valor = ""; int suma=0; bool hola = true;
            try
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    Console.Write("Ingrese numero {0}: ", cont + 1);
                    valor = Console.ReadLine();
                    vector[cont] = Convert.ToInt32(valor);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR");
                hola = false;
                Console.ReadKey();
            }
            if (hola == true)
            {
                //Imprimir numeros pares
                Console.WriteLine("Estos son los numeros que estan en las posiciones pares: ");
                for (int cont = 0; cont < 10; cont++)
                {
                    if ((cont + 1) % 2 == 0)
                    {
                        Console.Write("Posicion {0} :", cont + 1);
                        Console.WriteLine(vector[cont]);
                        suma = vector[cont] + suma;
                    }
                }

                Console.WriteLine("La suma de esos numeros es: {0}", suma);
                Console.ReadKey();
            } //fin bool
        } //fin main
    }
}
