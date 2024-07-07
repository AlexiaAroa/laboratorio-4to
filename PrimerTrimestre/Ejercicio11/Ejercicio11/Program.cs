using System;
namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int op; double leer; double resultado; 
                do {
                Console.Clear();
                Console.WriteLine("1_Pasar de centimetros a pies\n2_Pasar de centimetros a pulgadas\n3_Pasar de pies a centimetros\n4_Pasar de pulgadas a centimetros\n5_Pasar de pies a pulgadas\n6_Pasar de pulgadas a pies\n7_Salir");
                    op = Int32.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese centimetros: ");
                            leer = double.Parse(Console.ReadLine());
                            resultado = leer / 30.46;
                            Console.Write("Son ");
                            Console.Write(resultado);
                            Console.WriteLine(" pies");
                            break;

                        case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese centimetros: ");
                            leer = double.Parse(Console.ReadLine());
                            resultado = leer / 2.54;
                            Console.Write("Son ");
                            Console.Write(resultado);
                            Console.WriteLine(" pulgadas");
                            break;

                        case 3:  //pies a cm
                        Console.Clear();
                        Console.WriteLine("Ingrese pies: ");
                            leer = double.Parse(Console.ReadLine());
                            resultado = leer * 30.46;
                            Console.Write("Son ");
                            Console.Write(resultado);
                            Console.WriteLine(" centimetros");
                            break;
                        case 4:  //Pulgadas a cm
                        Console.Clear();
                        Console.WriteLine("Ingrese pulgadas: ");
                            leer = double.Parse(Console.ReadLine());
                            resultado = leer * 2.54;
                            Console.Write("Son ");
                            Console.Write(resultado);
                            Console.WriteLine(" centimetros");
                            break;

                        case 5:  //Pies a pulgadas
                        Console.Clear();
                        Console.WriteLine("Ingrese pies: ");
                            leer = double.Parse(Console.ReadLine());
                            resultado = leer * 12;
                            Console.Write("Son ");
                            Console.Write(resultado);
                            Console.WriteLine(" pulgadas");
                            break;

                        case 6:  //Pulgadas a pies
                        Console.Clear();
                        Console.WriteLine("Ingrese pulgadas: ");
                            leer = double.Parse(Console.ReadLine());
                            resultado = leer * 0.0833333;
                            Console.Write("Son ");
                            Console.Write(resultado);
                            Console.WriteLine(" pies");
                            break;
                        case 7:
                        Console.Clear();
                        Console.WriteLine("ADIOS");
                            break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Op inexistente, reingrese op");
                            break;
                    }
                Console.ReadLine();
                } while (op !=7);
            Console.ReadKey();
        }
    }
}