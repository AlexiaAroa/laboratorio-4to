using System;
//Hacer un programa que calcule e imprima la sumatoria de los cuadrados de los números del 1 hasta N, teniendo como dato de entrada el valor de N.
namespace _2do_trimestre_ejercicios2POOv
{
    class Cuadrado
    {
        private int limite, limite2, cont = 1, cont2 = 1, suma, ac;
        public void Ingresar()
        {
            Console.WriteLine("Ingrese numero limite");
            limite = int.Parse(Console.ReadLine());
        }
        public void Calculo()
        {
            limite2 = limite;
            do
            {
                ac = cont2 * cont2;
                Console.WriteLine("El cuadrado de " +cont2+ " es: "+ac);
                suma = ac + suma;
                ac = 0;
                cont2++;
                cont++;
            } while (cont <= limite2);
        }
        public void Imprimir()
        {
            Console.WriteLine("La suma de los cuadrados es: " + suma);
        }
        static void Main(string[] args)
        {
            Cuadrado cua = new Cuadrado();
            cua.Ingresar();
            cua.Calculo();
            cua.Imprimir();
            Console.ReadKey();
        }
    }
}
