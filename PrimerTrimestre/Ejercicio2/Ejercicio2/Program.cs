using System;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;
            int cont = 10;
            int seguir;
            do{
                Console.WriteLine("Ingrese el nombre del mes");
                mes = (Console.ReadLine());
                switch (mes)
                {
                    case ("enero"):
                        Console.WriteLine("El mes enero es el nro 1");
                        break;
                    case ("febrero"):
                        Console.WriteLine("El mes febrero es el nro 2");
                        break;
                    case ("marzo"):
                        Console.WriteLine("El mes marzo es el nro 3");
                        break;
                    case ("abril"):
                        Console.WriteLine("El mes abril es el nro 4");
                        break;
                    case ("mayo"):
                        Console.WriteLine("El mes mayo es el nro 5");
                        break;
                    case ("junio"):
                        Console.WriteLine("El mes junio es el nro 6");
                        break;
                    case ("julio"):
                        Console.WriteLine("El mes julio es el nro 7");
                        break;
                    case ("agosto"):
                        Console.WriteLine("El mes agosto es el nro 8");
                        break;
                    case ("septiembre"):
                        Console.WriteLine("El mes septiembre es el nro 9");
                        break;
                    case ("octubre"):
                        Console.WriteLine("El mes octubre es el nro 10");
                        break;
                    case ("noviembre"):
                        Console.WriteLine("El mes noviembre es el nro 11");
                        break;
                    case ("diciembre"):
                        Console.WriteLine("El mes diciembre es el nro 12");
                        break;
                    default:
                        Console.WriteLine("El mes que ingreso no existe");
                        break;
                }
                Console.WriteLine("Desea saber el numero de otro mes?");
                Console.WriteLine("1_SI      2_NO");
                seguir = Int32.Parse(Console.ReadLine());
                if (seguir == 1)
                    cont = cont + 1;
                if (seguir == 2)
                    cont = 1;
            } while (cont >= 10);
            Console.ReadKey(); 
        }
    }
}