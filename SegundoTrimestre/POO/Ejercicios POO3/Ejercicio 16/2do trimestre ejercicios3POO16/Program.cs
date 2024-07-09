using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_trimestre_ejercicios3POO16
{
    class Operaciones
    {
        public int suma, resta, multiplicacion, division;
        public int SUMA(int a, int b)
        {
            suma = a + b;
            Console.WriteLine("La suma es: " + suma);
            return suma;
        }
        public int RESTA(int a, int b)
        {
            resta = a - b;
            Console.WriteLine("La resta es: " + resta);
            return resta;
        }
        public int MULTI(int a, int b)
        {
            multiplicacion = a * b;
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
            return multiplicacion;
        }
        public int DIV(int a, int b)
        {
            division = a / b;
            Console.WriteLine("La division es: " + division);
            return division;
        }
        static void Main(string[] args)
        {
            int num, num2;
            Console.WriteLine("Ingrese numero 1");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = Int32.Parse(Console.ReadLine());
            Operaciones mate = new Operaciones();
            mate.SUMA(num, num2);
            mate.RESTA(num, num2);
            mate.MULTI(num, num2);
            mate.DIV(num, num2);
            Console.ReadKey();

        }
    }
}
