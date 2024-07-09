using System;
//16.	Cargar un array de n enteros y calcular la media de los que estén en
//posiciones pares
namespace _2do_trimestre_ejercicio_array_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;int cont = 0; double ac = 0;
            //Ingresar tamaño del vector
            Console.WriteLine("Ingrese tamaño del vector: ");
            i = Int32.Parse(Console.ReadLine());
            double[] vector = new double[i];
            //Ingresar elementos de ese vector
            for (cont = 0; cont < i; cont++)
            {
                Console.Write("Ingrese nro {0}: ", cont + 1);
                vector[cont] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Estos son los numeros en las posiciones pares: ");

            for (cont = 0; cont < i; cont++)
            {
                if ((cont+1) % 2 == 0)
                {
                    Console.Write("Posicion par {0}, Nro {1} => ",cont+1,vector[cont]);
                    ac = vector[cont];
                    Console.WriteLine("La mitad de ese nro es: {0}",ac/2);
                }
            }            
            Console.ReadKey();
        } //fin main
    }
}
