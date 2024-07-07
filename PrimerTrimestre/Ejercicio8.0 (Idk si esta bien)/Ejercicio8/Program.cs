using System;
namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; int ac; int num2; int ac2; int ac3; int ac4; int ac5; int ac6; int ac7; int ac8;int ac9; int ac10;
            do
            {
                Console.WriteLine("Ingrese numero");
                num = Int32.Parse(Console.ReadLine());
           } while (num <= 0);
            num2 = num;
            Console.WriteLine();
            Console.WriteLine();
            ac = num2 + num2;
            ac2 = num2 + ac;
            ac3 = ac + ac2;
            ac4 = ac2 + ac3;
            ac5 = ac3 + ac4;
            ac6 = ac4 + ac5;
            ac7 = ac5 + ac6;
            ac8 = ac6 + ac7;
            ac9 = ac7 + ac8;
            ac10 = ac8 + ac9;

            Console.WriteLine(ac);
            Console.WriteLine(ac2);
            Console.WriteLine(ac3);
            Console.WriteLine(ac4);
            Console.WriteLine(ac5);
            Console.WriteLine(ac6);
            Console.WriteLine(ac7);
            Console.WriteLine(ac8);
            Console.WriteLine(ac9);
            Console.WriteLine(ac10);

            Console.ReadKey();
        }
    }
}
