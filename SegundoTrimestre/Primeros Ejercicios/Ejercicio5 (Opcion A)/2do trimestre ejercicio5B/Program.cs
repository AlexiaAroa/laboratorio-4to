//EJERCICIO NRO 2
//IMPLEMENTAR LA CLASE OPERACIONES, SE DEBEN CARGAR DOS VALORES ENTEROS, CALCULAR LA SUMA, RESTA, MULTIPLICACION Y DIVISION
//CADA UNO EN UN METODO DISTINTO E IMPRIMIR LOS RESULTADOS(OPCION A ES QUE IMPRIMA EN UN METODO, OPCION B QUE IMPRIMA EN CADA METODO)
//OPCION A
using System;
namespace _2do_trimestre_ejercicio5B
{
    class Operaciones
    {
        private int num1, num2, suma, resta, multi, div;
        public void Grabar()
        {
            Console.WriteLine("Ingrese numero uno");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero dos");
            num2 = int.Parse(Console.ReadLine());
        }
        public void Suma()
        {
            suma = num1 + num2;   
        }
        public void Resta()
        {
            resta = num1 - num2;
        }
        public void Multiplicacion()
        {
            multi = num1 * num2;
        }
        public void Division()
        {
            div = num1 / num2;
        }
        public void Mostrar()
        {
            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine("La resta es: "+resta);
            Console.WriteLine("La multiplicacion es: "+multi);
            Console.WriteLine("La division es: "+div);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Operaciones num = new Operaciones();
            num.Grabar();
            num.Suma();
            num.Resta();
            num.Multiplicacion();
            num.Division();
            num.Mostrar();
        }
    }
}