using System;
/*La suma de los ángulos internos de un triángulo es de 180 grados.
 *  Crear un programa que lea 2 ángulos A y B y que determine el valor del tercer ángulo.
 *   El algoritmo deberá verificar que el tercer valor no sea cero o negativo, y si cualquiera de ellos ocurre,
 *    imprimir un mensaje de Esto No Es Un Triángulo.*/
namespace _2do_trimestre_ejercicios2POOii
{
    class Triangulo
    {
        private int angulo, angulo2, angulo3, aux, cont=0;
        public void grabar()
        {
            Console.WriteLine("Ingrese primer angulo");
            angulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo angulo");
            angulo2 = int.Parse(Console.ReadLine());
            aux = angulo + angulo2;
        }
        public void pensar()
        {
            if(aux<180 && aux>=1)
            {
                angulo3 = 180 - aux;
                cont = 0;
            }
            if (aux > 180)
                cont++;
            if (angulo<=0 && angulo2<=0)
                cont++;
            if(angulo<0 || angulo2 < 0)
                cont++;
            if (cont >= 1)
                Console.WriteLine("Esto no es un triangulo");
            else
                Console.WriteLine("El tercer angulo es: " + angulo3);
        }
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            tri.grabar();
            tri.pensar();
            Console.ReadKey();
        }
    }
}