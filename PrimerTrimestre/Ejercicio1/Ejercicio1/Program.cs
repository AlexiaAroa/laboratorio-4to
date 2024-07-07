using System;
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Faren = 1.8; double Multi; double Celsius; int op; int op2; int hola = 10;
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1_Pasar de Celsius a Fahrenheit");
                Console.WriteLine("2_Farenheit a Celsius");
                Console.WriteLine("3_Salir");
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                { // segun, opciones
                    case 1:
                        {
                            Console.WriteLine("Ingrese grados Celsius");
                            Celsius = double.Parse(Console.ReadLine());
                            Multi = (Faren * Celsius) + 32;
                            Console.WriteLine("A grados Fahrenheit es: " + Multi);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Ingrese grados Fahrenheit");
                            Celsius = double.Parse(Console.ReadLine());
                            Multi = (Celsius - 32) / Faren;
                            Console.WriteLine("A grados Fahrenheit es: " + Multi);
                        }
                        break;
                    case 3:
                        Console.WriteLine("ADIOS");
                        break;

                } // segun, opciones fin

                Console.WriteLine("Desea cambiar otros grados?\n1_SI\n2_NO");
                op2 = Int32.Parse(Console.ReadLine());
                if (op2 == 1)
                    hola = hola + 1;
                if (op2 == 2)
                    hola = 1;
            } while (hola >= 10);
            Console.ReadKey();
        }
    }
}