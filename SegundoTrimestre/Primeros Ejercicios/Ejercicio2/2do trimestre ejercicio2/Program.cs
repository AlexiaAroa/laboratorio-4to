using System;
//desarrollar un programa que cargue los lados de un triangulo e implemente los siguientes metodos:
//inicializar los atributos , imprimir el lado mayor , si es equilatero o no
namespace _2do_trimestre_ejercicio2
{
    class Triangulo
    {
        private int lado1, lado2, lado3; //atributos
        public void inicializar()
        {
            Console.WriteLine("Ingrese lado 1 del triangulo");
            lado1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 2 del triangulo");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 3 del triangulo");
            lado3 = int.Parse(Console.ReadLine());
        }
        public void Imprimir()
        {
            Console.Write("Lado 1: ");
            Console.WriteLine(lado1);
            Console.Write("Lado 2: ");
            Console.WriteLine(lado2);
            Console.Write("Lado 3: ");
            Console.WriteLine(lado3);
        }
        public void Mayor()
        {
            if (lado1>lado2 && lado1>lado3)
            {
                Console.WriteLine("El lado 1 es mayor");
            }
            if (lado2 > lado1 && lado2 > lado3)
            {
                Console.WriteLine("El lado 2 es mayor");
            }
            if (lado3 > lado2 && lado3 > lado1)
            {
                Console.WriteLine("El lado 3 es mayor");
            }
          
        }
        public void Equilatero()
        {
         if (lado1==lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else
            {
                Console.WriteLine("El triangulo no es equilatero");
            }
         Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            tri.inicializar(); //objeto.metodo();
            tri.Imprimir();
            tri.Mayor();
            tri.Equilatero();
        }
    }
}
