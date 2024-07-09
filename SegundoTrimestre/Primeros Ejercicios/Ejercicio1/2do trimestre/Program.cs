using System;
namespace _2do_trimestre
{
    class Persona
    {
        private string nombre; //atributo
        private int edad; //atributo
        public void inicializar() //metodo
        {
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            string linea;
            Console.WriteLine("Ingrese edad");
            linea = Console.ReadLine(); //lee la edad en modo string
            edad = int.Parse(linea); //convierte la edad en tipo int 
        }
        public void Imprimir() //metodo
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }
        public void EsMayorEdad()  //metodo 
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //  BUSCAR 
            //instanciar = llamar
            // un objeto puede instanciar mas de una clase??
            //nombre de las clases       nombre del objeto  =   NEW   nombre de la clase
            // cubo                         mi cubo         =   NEW    CUBO
            // EJERCICIO 1
            //se confecciona una clase que permita cargar el nombre y la edad de una persona , y mostrar los datos cargados por
            //pantalla , imprimir un cartel que diga si es mayor de edad 
            //esta no es la unica forma para programar esto


            Persona per1 = new Persona();
            
            per1.inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
            //objeto, punto, nombre del metodo y parentesis ;
        }
    }
}
