using System;
namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, num3, num4, num5, cont = 10, op, cont2 = 0, ac;
            do {
                Console.Clear();
                Console.WriteLine("Ingrese numero 1");
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese numero 2");
                num2 = Int32.Parse(Console.ReadLine());
                if (num < num2)
                {  //inicio if
                    num5 = num2 - num;
                    Console.WriteLine();
                    Console.Write("Hay " + num5 + " numeros de diferencia\n\nEstos son los numeros que estan entre el numero " + num + " y numero " + num2 + ":\n\n");
                    num3 = num;
                    num4 = num2;
                    while (num3 < num4) {  // inicio while
                        num3 = num3 + 1;
                        Console.Write(num3+"\n");
                    } //fin while
                    Console.WriteLine();
                    Console.WriteLine("El primer numero ingresado es menor\nLos multiplos de ese numero son: ");
                    while (cont2 <= 9)
                    {
                        cont2 = cont2 + 1;
                        ac = num * cont2;
                        Console.WriteLine(ac);
                    }
                } //fin if
                if (num2 < num)
                {  //inicio if
                    num5 = num - num2;
                    Console.WriteLine();
                    Console.Write("Hay " + num5 + " numeros de diferencia\n\nEstos son los numeros que estan entre el numero " + num + " y numero " + num2 + ":\n\n");
                    num3 = num;
                    num4 = num2;
                    while (num4 < num3)
                    {  // inicio while
                        num4 = num4 + 1;
                        Console.Write(num4+"\n");
                    } //fin while
                    Console.WriteLine("\nEl primer numero ingresado es menor\nLos multiplos de ese numero son: ");
                    while (cont2 <= 9)
                    {
                        cont2 = cont2 + 1;
                        ac = num2 * cont2;
                        Console.WriteLine(ac);
                    }
                } //fin if
                if (num == num2)
                {
                    Console.WriteLine("Los numeros son identicos\nLos multiplos de ese numero son: ");
                    while (cont2 <= 9)
                    {
                        cont2 = cont2 + 1;
                        ac = num * cont2;
                        Console.WriteLine(ac);
                    }
                }
                Console.WriteLine("Desea ingresar otros numeros?\n1_Si\n2_No");
                op = Int32.Parse(Console.ReadLine());
                if (op == 1)
                    cont = cont + 1;
                if (op == 2)
                    cont = 1;
            } while (cont>=10);
            Console.ReadKey();   
        }
    }
}