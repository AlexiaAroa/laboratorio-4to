using System;
//plantear un clase ''club'' y otra clase ''socio'' (dos clases) :v, la clase socio debe tener los siguientes atributos privados
//nombre y antiguedad del club (expresada en años, 5,6,7)
//definir dos propiedades para poder acceder al nombre y la antiguedad del socio
//la clase club debe tener como atributo tres objetos de la clase socio, 
//se debe imprimir el socio con mayor antiguedad
//hay dos formas, poner los valores ya asignados, o si queremos lo cargamos nosotros,como queramos nosotros xD
namespace _2do_trimestre_ejercicio7
{
    class Club
    {
        private string nombre;
        private int años;
        public string Nombre
        {
            set //inicializar el atributo, cuando viene el valor del objeto, lo que hacemis eso, es para escribir un nombre  un variable
                //es un tributo,   tenemos que decidir si utilizar la propiedad o un metodo
            {
                nombre = value;  //leo el nombre
            }
          get
            {
                return nombre;  // y lo devuelvo
            }
        }
        public int Anio
        {
            set
            {
                años = value;
            }
            get
            {
                return años;
            }
        }
        public void imprimir()
        { 
            Console.WriteLine(nombre + ", antiguedad en el club:  " + años +" años");
        }
    }
    class Socio {
        private Club socio1, socio2, socio3;
        private Socio()
        {
            socio1 = new Club();   //objetos
            socio1.Nombre = "Paola";
            socio1.Anio = 5;  
            socio2 = new Club();  //objetos 
            socio2.Nombre = "Olivia";
            socio2.Anio = 4;
            socio3 = new Club();  //objetos
            socio3.Nombre = "Alejo";
            socio3.Anio = 8;
            if (socio1.Anio > socio2.Anio && socio1.Anio>socio3.Anio)
            {
               Console.WriteLine("El socio/a {0} estuvo mas años en el club", socio1.Nombre); Console.WriteLine();
            }
            if (socio2.Anio > socio1.Anio && socio2.Anio > socio3.Anio)
           {
               Console.WriteLine("El socio/a {0} estuvo mas años en el club", socio2.Nombre); Console.WriteLine();
            }
            if (socio3.Anio > socio2.Anio && socio3.Anio > socio1.Anio)
            {
               Console.WriteLine("El socio/a {0} estuvo mas años en el club", socio3.Nombre); Console.WriteLine();
            }
        }
      public void print()
        {
            socio1.imprimir();
            socio2.imprimir();
            socio3.imprimir();
        }
        static void Main(string[] args)
        {
            Socio socio = new Socio();
            Console.WriteLine("El club tiene 10 años de antiguedad\n");
            socio.print();
            Console.ReadKey();
        }
    }
}