using System;
//EJERCICIO 3: DESARROLLAR UNA CLASE QUE REPRESENTE UN CUADRADO Y TENGA LOS SIGUIENTES METODOS:
//CARGAR LOS LADOS, IMPRIMIR SU PERIMETRO Y SUPERFICIE
namespace _2do_trimestre_ejercicio3
{
   class Cuadrado
    {
        private int lado, per, super;
        public void inicializar()
        {
            Console.WriteLine("Ingrese lado del cuadrado");
            lado = int.Parse(Console.ReadLine());
        }
        public void Perimetro()
        {
            per = lado + lado + lado + lado;
            Console.WriteLine("El perimetro es: {0}", per);
        }
        public void Superficie()
        {
            super = lado * lado;
            Console.WriteLine("La superficie es: " + super);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Cuadrado tri = new Cuadrado();
            tri.inicializar();
            tri.Perimetro();
            tri.Superficie();
        }
    }
}