//EJERCICIO PRACTICO 1
//CONFEXIONAR UNA CLASE QUE REPRESENTE A UN EMPLEADO, DEFINIR COMO ATRIBUTOS NOMBRE Y SUELDO 
//CONFEXIONAR LOS METODOS PARA LA CARGA DE DATOS, OTRO PARA IMPRIMIR LOS DATOS Y POR ULTIMO UNO 
//QUE IMPRIMA UN MENSAJE SI TIENE QUE PAGAR IMPUESTOS SI EL SUELDO ES MAYOR A $37.000
using System;
namespace _2do_trimestre_ejercicio4
{
    class Empleado
    {
        private int sueldo; private string nombre;
        public void cargar()
        {
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = int.Parse(Console.ReadLine());
        }
        public void imprimir()
        {
            Console.WriteLine("\nNombre: " +nombre);
            Console.WriteLine("Sueldo: "+sueldo);
        }
        public void impuesto()
        {
            if (sueldo >= 37000)
                Console.WriteLine("Usted tiene que pagar impuestos");
            else
                Console.WriteLine("Usted no tiene que pagar impuestos");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.cargar();
            emp.imprimir();
            emp.impuesto();
        }
    }
}