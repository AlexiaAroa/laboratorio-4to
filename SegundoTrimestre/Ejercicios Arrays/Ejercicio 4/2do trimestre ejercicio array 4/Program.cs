using System;
/*4.Se ingresan 10 números. La computadora los muestra eliminando las 
 repeticiones. */
namespace _2do_trimestre_ejercicio_array_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10]; string valor = ""; int cont = 0,cont4, cont3 = 0; int m = 0;int cont2=0,z=0; int[] vector2 = new int[cont]; int[] vector3 = new int[z];
            //INGRESAR NUMEROS
            for (cont = 0; cont < 10; cont++)
            {
                Console.Write("Ingrese numero [{0}]: ",cont+1);
                valor = Console.ReadLine();
                vector[cont] = Convert.ToInt32(valor);
            }


            do
            {

                //COMPARAR MAYOR
                for (cont = 0; cont < 10; cont++)
                {
                    if (vector[cont] > m)
                    {
                        m = vector[cont];
                    }
                }
                //IGUALAR (?
                for (cont = 0; cont < 10; cont++)
                {
                    if (m == vector[cont])
                    {
                        vector[cont] = 0;
                    }
                }
                Console.WriteLine(cont2);
                cont2++;

            } while (cont2 < 10);
           


            Console.WriteLine("_________________________");


            for (cont = 0; cont < 10; cont++)
            {
                Console.WriteLine(vector[cont]);
            }


            Console.ReadKey();
        }
    }
}

/*  int[] vector = new int[10]; string valor = ""; int aux=0;
            for(int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("Ingrese numero {0}: ", cont+1);
                valor = Console.ReadLine();
                vector[cont] = Convert.ToInt32(valor);
            }

            for(int cont = 0; cont < 10; cont++)
            {
                if (aux == vector[cont])
                {
                    
                }
            }*/


/*
 DE UN VIDEO: 
    for (cont = 0; cont < 10; cont++)
        {
            cont4 = 0;
            m = vector[cont];
            vector2[cont2] = m;
            cont2++;
            for (cont3 = 0; cont < 10; cont++)
            {
                if (vector2[cont3] == m)
                {
                    cont++;
                }
            }
            if (cont == 1)
            {
                vector3[z] = m;
                z++;
            }

        }
        Console.WriteLine("Imprimir vector sin repeticion");Console.WriteLine();
        Console.WriteLine(vector3[z]);

 */
