using System;
//6.Visualizar, contar y sumar los elementos pares que ocupan las posiciones
//impares de lista anterior. Imprimir las posiciones que ocupan dichos elementos 
//en la lista.
namespace _2do_trimestre_ejercicio_array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];string valor = ""; int suma = 0; bool hola = true;
            try
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    Console.Write("Ingrese numero [{0}]: ", cont + 1);
                    valor = Console.ReadLine();
                    vector[cont] = Convert.ToInt32(valor);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("ERROR");
                hola = false;
            }
            
            if (hola == true)
            {
                for (int cont = 0; cont < 10; cont++)
                {
                    if ((cont + 1) % 2 != 0)
                    {
                        if (vector[cont] % 2 == 0)
                        {
                            Console.WriteLine("En la posicion impar {0} esta el nro par {1}", cont + 1, vector[cont]);
                            suma = suma + vector[cont];
                        }
                    }
                }
                Console.WriteLine("La suma de esos numeros es {0}", suma);
            }
            Console.ReadKey();
        } //fin main
    }
}
