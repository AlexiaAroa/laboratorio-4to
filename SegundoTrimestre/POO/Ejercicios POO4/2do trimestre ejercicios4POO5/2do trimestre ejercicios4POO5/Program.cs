using System;
//5.La actividad de una pequeña empresa es la compra-venta de productos 
//tecnológicos. La compañía discrima los productos importados de los productos 
//de elaboración nacional ya que sobre los importados debe pagar un IVA del 10,5 % 
//y sobre los nacionales un impuesto del 21 % (ambos sobre el valor neto del 
//producto).
//Determinar el monto total de IVA que la empresa pagó en su última compra.
//Cree una nueva clase con un método Main y demuestre el funcionamiento del punto 
//anterior.
namespace _2do_trimestre_ejercicios4POO5
{
    class Empresa
    {
        private double productosimportados, productosnacionales, productosimportadosIVA, productosnacionalesIVA;
        public double ProductosimportadosIVA
        {
            set
            {
                productosimportadosIVA = value;
            }
            get
            {
                return productosimportadosIVA;
            }
        }
        public double ProductosnacionalesIVA
        {
            set
            {
                productosnacionalesIVA = value;
            }
            get
            {
                return productosnacionalesIVA;
            }
        }
        public double Productosimportados
        {
            set
            {
                productosimportados = value;
            }
            get
            {
                return productosimportados;
            }
        }
        public double Productosnacionales
        {
            set {
                productosnacionales = value;
            }
            get
            {
                return productosnacionales;
            }
        }
        public void imprimirimportados()
        {
            Console.WriteLine("El precio de los productos importados es: $" + Productosimportados);
        }
        public void imprimirimportadosIVA()
        {
            Console.WriteLine("El precio del IVA de los productos importados es: $" + ProductosimportadosIVA);
        }
        public void imprimirnacionales()
        {
            Console.WriteLine("El precio de los productos nacionaeles es :$" + Productosnacionales);
        }
        public void imprimirnacionalesIVA()
        {
            Console.WriteLine("El precio del IVA de los productos nacionales es :$" + ProductosnacionalesIVA);
        }
    }  //fin class empresa
    class Empresa2
    {
        public Empresa impor, nacio,imporIVA,nacioIVA;
        public Empresa2()
        {
            impor = new Empresa();
            impor.Productosimportados = 300;

            imporIVA = new Empresa();
            imporIVA.ProductosimportadosIVA = (10.5 * impor.Productosimportados / 100);

            nacio = new Empresa();
            nacio.Productosnacionales = 200;

            nacioIVA = new Empresa();
            nacioIVA.ProductosnacionalesIVA = (21 * nacio.Productosnacionales / 100);
        } 
         public void total()
        {
            impor.imprimirimportados();
            imporIVA.imprimirimportadosIVA();
            nacio.imprimirnacionales();
            nacioIVA.imprimirnacionalesIVA();
          
        }
        public void IVA()
        {
            Console.WriteLine("El precio de IVA en total es: $"+(imporIVA.ProductosimportadosIVA+nacioIVA.ProductosnacionalesIVA));
        }
        
  
        static void Main(string[] args)
        {
            Empresa2 objeto = new Empresa2();
            objeto.total();
            objeto.IVA();
            Console.ReadKey();
        }
    }
}
