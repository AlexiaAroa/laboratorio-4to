using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1; int cont2 = 0; int cont3 = 0; int cont4 = 100; int cont5 = 0; int cont6 = 0; int op;

            do
            {
                Console.WriteLine("Que desea ver?");
                Console.WriteLine("1_Mostrar los nùmeros impares entre el 0 y el 100");
                Console.WriteLine("2_Mostrar los números pares entre el 0 y el 100");
                Console.WriteLine("3_Mostrar los números del 0 al 100");
                Console.WriteLine("4_Mostrar los números del 100 al 0");
                Console.WriteLine("5_Mostrar los multiplos de 3 del 0 al 100");
                Console.WriteLine("6_Mostrar los multiplos de 3 y de 2 entre el 0 y 100");
                Console.WriteLine("7_Salir");
                op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Estos son los numeros impares del 0 al 100: ");
                        while (cont <= 100)   //numeros impares
                        {
                            Console.WriteLine(cont);
                            cont = cont + 2;
                        } //fin numeros impares
                        break;
                    case 2:
                        Console.WriteLine("Estos son los numeros pares del 0 al 100: ");
                        while (cont2 <= 100)   //numeros pares
                        {
                            Console.WriteLine(cont2);
                            cont2 = cont2 + 2;
                        } //fin numeros pares
                        break;
                    case 3:
                        Console.WriteLine("Estos son los numeros del 0 al 100: ");
                        while (cont3 <= 100)   //numeros del 0 al 100
                        {
                            Console.WriteLine(cont3);
                            cont3 = cont3 + 1;
                        } //fin numeros del 0 al 100
                        break;
                    case 4:
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine("Estos son los numeros del 0 al 100: ");
                        while (cont4 >= 0)   //numeros del 100 al 0
                        {
                            Console.WriteLine(cont4);
                            cont4 = cont4 - 1;
                        } //fin numeros del 100 al 0
                        break;
                    case 5:
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine("Estos son los numeros multiplos de 3 del 0 al 100: ");
                        while (cont5 <= 100)   //multiplos de 3 del 0 al 100
                        {
                            Console.WriteLine(cont5);
                            cont5 = cont5 + 3;
                        } //fin multiplos de 3 del 0 100
                        break;
                    case 6:
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine("Estos son los multiplos de 2 y 3 del 0 al 100: ");
                        while (cont6 <= 100)   //multiplos de 2 y 3 del 0 al 100
                        {
                            if (cont6 % 2 == 0)
                            {
                                Console.Write(cont6);
                                Console.Write("<= Este numero es multiplo de 2");
                            }
                            Console.WriteLine();
                            if (cont6 % 3 == 0)
                            {
                                Console.Write(cont6);
                                Console.Write("<= Este numero es multiplo de 3");
                            }
                            Console.WriteLine();

                            //          if (cont6 % 2 == 0 && cont6 % 3 == 0)
                            //        {
                            //          Console.Write(cont6);
                            //        Console.Write("<=Este numero es multiplo de 3 y de 2");
                            //  }
                            Console.WriteLine();
                            cont6 = cont6 + 1;
                        } //fin multiplos de 2 y 3 del 0 100
                        break;
                    case 7:
                        Console.WriteLine("ADIOS");
                        break;

                    default:
                        Console.WriteLine("\nop inexistente\n");
                        break;
                }
            } while (op != 7);

            Console.ReadKey();
        }
    }
}
