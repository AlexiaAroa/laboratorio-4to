using System;
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            int seguir;
            int cont = 10;
            do {
                Console.Clear();
                Console.WriteLine("Ingrese año");
                año = Int32.Parse(Console.ReadLine());
                if (año % 4 == 0 || año % 100 != 0 && año % 400 == 0)
                    Console.WriteLine("El año es bisiesto");
                else
                    Console.WriteLine("El año no es bisiesto");
                Console.WriteLine("\n\nDesea ingresar otro año?\n1_SI\n2_NO");
                seguir = Int32.Parse(Console.ReadLine());
                if (seguir == 1)
                    cont = cont + 1;
                if (seguir == 2)
                    cont = 1;
            } while (cont>=10);
            Console.ReadKey();
        }
    }
}
