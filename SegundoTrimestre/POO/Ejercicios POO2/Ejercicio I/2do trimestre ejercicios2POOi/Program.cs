using System;
//Un número perfecto es un entero tal que la suma de sus divisores propios, exceptuando él mismo, 
//es igual a él mismo. Hacer un programa que determine si un número N es perfecto, deficiente o abundante.
namespace _2do_trimestre_ejercicios2POOi
{
    class Perfecto
    {
        private int num, aux, div, ac = 0, aux2;
        public void grabar()
        { 
            Console.WriteLine("Ingrese numero");
            num = int.Parse(Console.ReadLine());
            aux = num;
            aux = aux - 1;
        }
        public void repetir()
        {
            do
            {
                while (num % aux == 0)
                {
                    div = aux;
                    aux2 = div;
                    ac = ac + aux2;
                    break;
                }
                aux = aux - 1;
            } while (aux > 0);

        }
        public void comparacion()
        {
            if (ac == num)
            {
                Console.WriteLine("La suma de sus divisores es " + ac);
                Console.WriteLine("El numero " + num + " es perfecto");
            }
            if (ac > num)
            {
                Console.WriteLine("La suma de sus divisores es " + ac);
                Console.WriteLine("El numero " + num + " es abundante");
            }
            if (ac < num)
            {
                Console.WriteLine("La suma de sus divisores es " + ac);
                Console.WriteLine("El numero " + num + " es deficiente");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Perfecto h = new Perfecto();
            h.grabar();
            h.repetir();
            h.comparacion();
            Console.ReadKey();
        }
    }
}