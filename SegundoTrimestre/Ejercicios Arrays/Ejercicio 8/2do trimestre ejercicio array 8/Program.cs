using System;
//8.Se ingresan 11 apellidos. La computadora los muestra resaltando aquel que, si los apellidos estuviesen ordenados alfabéticamente, ocuparía la posición central de la lista.  
namespace _2do_trimestre_ejercicio_array_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Apellidos = new string[11];
            for (int cont = 0; cont < Apellidos.Length; cont++)
            {
                Console.Write("Ingrese Apellido [{0}]:", cont + 1);
                Apellidos[cont] = Console.ReadLine();
            }
            // Console.Clear();
            Console.WriteLine("Ordenados Alfabeticamente:");
            for (int cont = 0; cont < 10; cont++)
            {
                for (int cont2 = 0; cont2 < 10; cont2++)
                {
                    if (Apellidos[cont2].CompareTo(Apellidos[cont2 + 1]) > 0)
                    {
                        string Aux;
                        Aux = Apellidos[cont2];
                        Apellidos[cont2] = Apellidos[cont2 + 1];
                        Apellidos[cont2 + 1] = Aux;
                    }
                }
            }
            //IMPRIMIR ALFABETICAMENTE
            for(int cont = 0; cont < 11; cont++)
            {
                Console.WriteLine(Apellidos[cont]);
            }
            Console.WriteLine();
            //_________________________________________________________
            for (int cont = 0; cont < Apellidos.Length; cont++)
            {
               //   Console.WriteLine("{0}. {1}", cont + 1, Apellidos[cont]);
              
                if (cont == 5)
                {
                    Console.WriteLine("El apellido del medio es: {0}. {1}", cont+1, Apellidos[cont]);
                }
            }
            Console.ReadKey();
        }
    }
}
