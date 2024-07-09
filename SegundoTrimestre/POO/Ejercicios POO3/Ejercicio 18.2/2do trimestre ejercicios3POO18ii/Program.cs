using System;
//Variante 2: Debe realizar el mismo cálculo pero con un método que no devuelva valores 
//solo que escriba en una variable del segmento de código implementado y luego volcar esta 
//variable a la etiqueta o mensaje emergente.

namespace _2do_trimestre_ejercicios3POO18ii
{
    class Triangulo
    {
        public double bases, altura, resultado;
       public Triangulo()
        {
            bases = 3;
            altura = 4;
            resultado = (bases * altura) / 2;
        }
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            double final = tri.resultado;
            Console.WriteLine("La base es: "+final);
            Console.ReadKey();
        }
    }
}
