using System;
//En el ejercicio planteado debe realizar el cálculo de un área de un triángulo (b*h/2) 
//debe crear un método que reciba como parámetro la base del triángulo y la altura del mismo y 
//devuelva el  valor resultado a una etiqueta o por medio de un mensaje emergente. 

//Variante 2: Debe realizar el mismo cálculo pero con un método que no devuelva valores 
//solo que escriba en una variable del segmento de código implementado y luego volcar esta 
//variable a la etiqueta o mensaje emergente.

namespace _2do_trimestre_ejercicios3POO18
{
    class Triangulo
    {
        public double resultado;
        public double Area(double bases,double altura)
        {
            resultado =(bases * altura) / 2;
            Console.WriteLine("El area es: " + resultado);
            return resultado;
        }
        static void Main(string[] args)
        {
            double b, h;
            Console.WriteLine("Ingrese base del triangulo");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura del triangulo");
            h = double.Parse(Console.ReadLine());
            Triangulo tri = new Triangulo();
            tri.Area(b, h);
            Console.ReadKey();
        }
    }
}
