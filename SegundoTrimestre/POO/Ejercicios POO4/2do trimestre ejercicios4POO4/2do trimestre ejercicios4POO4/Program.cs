using System;
//4.Una empresa de transporte de carga necesita determinar el peso total 
//de los productos a transportar por un camión. Existen dos tipos de productos: 
//productos normales y productos frágiles. Los últimos necesitan embalaje especial 
//y esto incrementa, en promedio, un 10% el peso del producto.
//Determinar el peso total de un conjunto de productos que serán asignados a un 
//camión.
//Cree una nueva clase con un método Main y demuestre el funcionamiento del punto 
//anterior.


namespace _2do_trimestre_ejercicios4POO4
{
    class Empresa
    {
        private int productosnormales, productosfragiles;
        public int Productosnormales
        {
            set
            {
                productosnormales = value;
            }
            get
            {
                return productosnormales;
            }
        }
        public int Productosfragiles
        {
            set
            {
                productosfragiles = value;
            }
            get
            {
                return productosfragiles;
            }
        }
        public void imprimir()
        {
            Console.WriteLine("El peso de los productos normales es: " + productosnormales+ "kilos");
           
        }
        public void imprimir2()
        {
            Console.WriteLine("El peso de los productos fragiles es: " + productosfragiles + "kilos");
        }

    }
    class Program{
        public Empresa pesonor, pesofra;
        public Program()
        {
            pesonor = new Empresa();
            pesonor.Productosnormales = 1000;
            pesofra = new Empresa();
            pesofra.Productosfragiles = 1000+(10*1000/100);
        
        }
        public void total()
        {
            pesonor.imprimir();
            pesofra.imprimir2();
            int todo = pesonor.Productosnormales + pesofra.Productosfragiles;
            Console.WriteLine("El peso total es: " + todo);
        }

        static void Main(string[] args)
        {
            Program objeto = new Program();
            objeto.total();
            Console.ReadKey();
        }
    }
}
