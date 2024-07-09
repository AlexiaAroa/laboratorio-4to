using System;
/*Construir un programa que lea un Número N, y que determine e imprima la serie de Ulam para el número leido.*/

namespace _2do_trimestre_ejercicios2POOiv
{
    class Ulam
    {
        private int numero;
        public void Ingresar()
        {
            Console.WriteLine("Ingrese numero");
            numero = int.Parse(Console.ReadLine());
        }
        public void Suma()
        {

        }
        static void Main(string[] args)
        {
            Ulam num = new Ulam();
            num.Ingresar();
            num.Suma();
        }
    }
}
