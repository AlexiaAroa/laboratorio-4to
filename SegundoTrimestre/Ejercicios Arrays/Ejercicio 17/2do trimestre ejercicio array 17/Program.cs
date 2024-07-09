using System;
/* 17.Escribir una clase que intercale los valores de dos arreglos 
 * unidimensionales dados, previamente ordenados, de modo que el arreglo 
 * resultante quede ordenado con el mismo criterio. 
 */
namespace _2do_trimestre_ejercicio_array_17
{
    class Program
    {

        public int[] vector = new int[10]; 
        public int[] vector2 = new int[10];
        public int[] vector3 = new int[20];
        public void Guardar()
        {
            
            Console.WriteLine("VECTOR 1");
            for (int cont = 0; cont < 10; cont++)
            {
                Console.Write("Ingrese nro {0}: ",cont+1);
                vector[cont] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("VECTOR 2");
            for (int cont = 0; cont < 10; cont++)
            {
                Console.Write("Ingrese nro {0}: ",cont+1);
                vector2[cont] = Int32.Parse(Console.ReadLine());
            }
        }
        public void Ordenar()
        {
            Console.WriteLine("VECTOR 1 ORDENADO: ");
            Array.Sort(vector);
            for(int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine(vector[cont]);
            }

            Console.WriteLine("VECTOR 2 ORDENADO: ");
            Array.Sort(vector2);
            for(int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine(vector2[cont]);
            }
        }
        public void Intercalar()
        {
            Console.WriteLine("METODO INTERCALAR");
            for (int cont = 0; cont < 20; cont++) {
                while (cont < 10)
                {
                    vector3[cont] = vector[cont];
                }
                while (cont > 9)
                {
                    vector3[cont] = vector2[cont];
                }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("METODO IMPRIMIR");
            for (int cont = 0; cont < 20; cont++)
            {
                Console.WriteLine("VECTOR 3");
                Console.WriteLine(vector3[cont]);
            }
        }
        static void Main(string[] args)
        {
            Program OBJETO = new Program();
            OBJETO.Guardar();
            OBJETO.Ordenar();
            OBJETO.Intercalar();
            OBJETO.Imprimir();
            Console.ReadKey();
            //CREO QUE VA ARRAYLIST >:V !

        }//fin main
    } //fin class
}

/*
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

     */
