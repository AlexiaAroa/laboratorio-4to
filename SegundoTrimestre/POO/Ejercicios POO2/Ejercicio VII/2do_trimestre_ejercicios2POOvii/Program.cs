using System;
//Elaborar un programa que lea un número, y que genere e imprima la tabla de multiplicar para el número leído.
namespace _2do_trimestre_ejercicios2POOvii
{
    class Tabla
    {
        private int numero, cont = 0, aux, ac;
        public void Leer()
        {
            Console.WriteLine("Ingrese un numero para multiplicar");
            numero = int.Parse(Console.ReadLine()); aux = numero;
        }
        public void Generar()
        {
            while (cont <= 12)
            {
                ac = aux * cont;
                Console.WriteLine(aux + "*" + cont + "= " + ac);
                cont++;
            }   
        }
            static void Main(string[] args)
        {
            Tabla num = new Tabla();
            num.Leer();
            num.Generar();
            Console.ReadKey();
        }
    }
}
