//EJERCICIO NRO 2
//IMPLEMENTAR LA CLASE OPERACIONES, SE DEBEN CARGAR DOS VALORES ENTEROS, CALCULAR LA SUMA, RESTA, MULTIPLICACION Y DIVISION
//CADA UNO EN UN METODO DISTINTO E IMPRIMIR LOS RESULTADOS(OPCION A ES QUE IMPRIMA EN UN METODO, OPCION B QUE IMPRIMA EN CADA METODO)
//OPCION B  
using System;
namespace _2do_trimestre_ejercicio5
{
    class Operaciones
    {
        private int num1, num2, suma, resta, multi, div;
        public void Cargar()
        {
            Console.WriteLine("Ingrese numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = int.Parse(Console.ReadLine());
        }
        public void Suma()
        {
            suma = num1 + num2;
            Console.WriteLine(); Console.WriteLine("La suma es :" + suma);
        }
        public void Resta()
        {
            resta = num1 - num2;
            Console.WriteLine(); Console.WriteLine("La resta es :" + resta);
        }
        public void Multiplicacion()
        {
            multi = num1 * num2;
            Console.WriteLine(); Console.WriteLine("La multiplicacion es :" + multi);
        }
        public void Division()
        {
            div = num1 / num2;
            Console.WriteLine(); Console.WriteLine("La division es :" + div);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Operaciones num = new Operaciones();
            num.Cargar();
            num.Suma();
            num.Resta();
            num.Multiplicacion();
            num.Division();
        }
    }
}
