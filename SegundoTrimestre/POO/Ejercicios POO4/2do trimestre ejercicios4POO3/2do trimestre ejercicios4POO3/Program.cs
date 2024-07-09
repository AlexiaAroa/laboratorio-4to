using System;
//3.	En una determinada fábrica existen dos tipos de empleados: 
//los empleados permanentes y aquellos contratados por un trabajo específico.
//Los empleados permanentes reciben un salario mensual variable de acuerdo a 
//la categoría. Los empleados temporales perciben un pago equivalente a las 
//horas trabajadas, $19,45 por hora. 

//a)	Informe el total a pagar por la empresa a todos sus empleados.
//b)  Cree una nueva clase con un método Main y demuestre el funcionamiento 
//del punto anterior.


namespace _2do_trimestre_ejercicios4POO3
{
    class Program
    {
        private string categoria; private double salariomensual; private string nombre; private int horas;
        public int Horas
        {
            set
            {
                horas = value;
            }
            get
            {
                return horas;
            }
        }
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Categoria
        {
            set
            {
                categoria = value;
            }
            get
            {
                return categoria;
            }
        }
        public double Salariomensual
        {
            set
            {
                salariomensual = value;
            }
            get
            {
                return salariomensual;
            }
        }
        public void Imprimir()
        {
         //   Los empleados temporales perciben un pago equivalente a las
//horas trabajadas, $19,45 por hora. 
            Console.WriteLine("El empleado permanente " + nombre+ " de la categoria" + categoria+  " tiene que recibir $" + salariomensual);
            
            Console.WriteLine();
        }
        public void ImprimirTemp()
        {
            Console.WriteLine("El empleado temporal " + nombre + " trabajo " + horas + " horas y tiene que recibir $" + salariomensual);
        }

        
    }
    class Fin {
        public Program empleado1, empleado2, empleado3, temporal1;
        public Fin()
        {
            empleado1 = new Program();
            empleado1.Nombre = "Juan";
            empleado1.Categoria = "Mayor";
            empleado1.Salariomensual = 30000;
            empleado2 = new Program();
            empleado2.Nombre = "Alex";
            empleado2.Categoria = "Medio";
            empleado2.Salariomensual = 20000;
            empleado3 = new Program();
            empleado3.Nombre = "Fernando";
            empleado3.Categoria = "Bajo";
            empleado3.Salariomensual = 10000;

            temporal1 = new Program();
            temporal1.Nombre = "Jose";
            temporal1.Horas = 120;
            temporal1.Salariomensual = 19.45*temporal1.Horas;
        }
    
        public void Total()
        {
            empleado1.Imprimir();
            empleado2.Imprimir();
            empleado3.Imprimir();
            temporal1.ImprimirTemp();
            double todo = empleado1.Salariomensual + empleado2.Salariomensual + empleado3.Salariomensual+temporal1.Salariomensual;
            Console.WriteLine("La empresa debe pagar en total $"+todo); Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            Fin objeto = new Fin();
            objeto.Total();
            Console.ReadKey();
            
        }
    }
}
