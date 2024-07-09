using System;
/*Elaborar un programa que lea un Número N, y que genere e imprima los primeros N números de la serie de Fibonacci.*/

namespace _2do_trimestre_ejercicios2POOiii
{
    class Fibonacci
    {
        private int ver, a = 0, b = 1, c;
        public void Ingresar()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que desea ver");
            ver = int.Parse(Console.ReadLine()); Console.WriteLine();
        }
        public void Calculo()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            while ((ver - 2) > 0)
            {
                c = b + a;
                a = b;
                b = c;
                Console.WriteLine(c);
                ver--;
            }
        }
        static void Main(string[] args)
        {
            Fibonacci num = new Fibonacci();
            num.Ingresar();
            num.Calculo();
            Console.ReadKey();
        }
    }
}
