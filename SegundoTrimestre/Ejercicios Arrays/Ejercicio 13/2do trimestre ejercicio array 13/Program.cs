using System;
//13.Se ingresan dos vectores de N componentes enteras. La computadora los suma y muestra el vector resultante. 
namespace _2do_trimestre_ejercicio_array_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0; int cont = 0;
            Console.WriteLine("Ingrese tamaño de los vectores");
            i = Int32.Parse(Console.ReadLine());
            int[] vector = new int[i]; int[] vector2 = new int[i]; int[] vector3 = new int[i];
            //VECTOR 1________________________________________________
            Console.WriteLine("VECTOR 1");
            for(cont = 0; cont < i; cont++)
            {
                Console.Write("Ingrese nro {0}: ", cont + 1);
                vector[cont] = Int32.Parse(Console.ReadLine());
            }
            //VECTOR 2________________________________________________
            Console.WriteLine("VECTOR 2");
            for (cont = 0; cont < i; cont++)
            {
                Console.Write("Ingrese nro {0}: ", cont + 1);
                vector2[cont] = Int32.Parse(Console.ReadLine());
            }
            //SUMA______________________________________________________
            for (cont = 0; cont < i; cont++)
            {
                vector3[cont] = vector[cont] + vector2[cont];
            }

            //VECTOR 3_________________________________________________
            for (cont = 0; cont < i; cont++)
            {
                Console.WriteLine("La suma entre {0} y {1} es {2}", vector[cont], vector2[cont], vector3[cont]);
            }
            Console.ReadKey();
        }
    }
}
