using System;
//Un taxi puede realizar un viaje si tiene combustible para realizar x KM.
//El cálculo de consumo promedio de combustible es 1 litro cada 12,5 km 
//si no tiene pasajeros y si tiene pasajeros podrá recorrer 0,2 KM menos 
//por la cantidad de pasajeros. La cantidad de pasajeros máxima es 4.

//Permitir cargar combustible a través de una propiedad(set get) y, también, 
//codificar un constructor que acepte la cantidad de litros.

//Permitir a una cantidad de pasajeros ocupar el taxi.

//Verificar si el taxi puede realizar un viaje de "x" KM
//(tener en cuenta las condiciones anteriores).

//Crear una clase con un método Main para demostrar el funcionamiento de
//los puntos anteriores.

    //no tiene pasajeros -> cada 12,5 km es 1 litro
    //si tiene pasajeros -> recorre 0,2 km menos por cada pasajero
    //cantidad maxima de pasajeros 4
    //cargar combustible a traves de set,get
    //constructor con cantidad de litros
    //verificar si el taxi puede realizar el viaje
     
namespace _2do_trimestre_ejercicios4POO1
{
    class Auto
    {
        public double combustible,KM; public int pasajeros;
        public double Combustible
        {
            get
            {
                return combustible;
            }
            set
            {
                combustible = value;
            }
        }
        public int Pasajeros
        {
            set
            {
                pasajeros = value;
            }
            get
            {
                return pasajeros;
            }

        }
        public Auto()
        {
            combustible = 0;
        }
        public double kilometros(double kms)
        {  //no tiene pasajeros -> cada 12,5 km es 1 litro
           //si tiene 1 litro puede recorrer 12.5 km
           //si tiene ? litro puede recorrer x km
           //si tiene pasajeros -> recorre 0,2 km menos por cada pasajero
       //     Console.WriteLine("kms= "+kms);
            KM = combustible * 12.5;
            
          //  Console.WriteLine("KM = " + KM);
            return KM;
            
        }
        public void mensaje(double kms)
        {
            int cont = 0;
            // Console.WriteLine(kms+"ACA ESTOY"); 
            if (pasajeros == 0) {
                if(kms <= KM )
                    Console.WriteLine("Usted puede realizar el viaje");
            }
            else
                cont++;

                //Console.WriteLine("NO PUEDE VIAJAR, LE FALTA COMBUSTIBLE");
            double i = pasajeros; double n;
            if (pasajeros >= 1)
            {
                n = kms-(i * 0.2);
                Console.WriteLine(n);
                if ((KM-n)>=KM)
                {
                    Console.WriteLine("Usted puede realizar el viaje");
                    cont = 0;
                }
                else
                    cont++;

                if (cont>0)
                     Console.WriteLine("NO PUEDE VIAJAR, LE FALTA COMBUSTIBLE");
            }

        }
        public void Imprimir()
        {
            Console.WriteLine("Usted tiene " + combustible + " litros");
            if (pasajeros <= 4)
                Console.WriteLine("Usted lleva " + pasajeros + " pasajeros");
            else
            {
                Console.WriteLine("Usted no puede llevar a mas de 4 pasajeros");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Auto objeto = new Auto();
            double combus,km; int per;
            objeto.Imprimir();
            Console.WriteLine("Cuantos litros de combustible desea ingresar?");
            combus = double.Parse(Console.ReadLine());
            objeto.combustible = combus;
            Console.WriteLine("Cuantos pasajeros lleva?");
            per = Int32.Parse(Console.ReadLine());
            objeto.pasajeros = per;
            Console.WriteLine("Cuantos km desea recorrer?");
            km = double.Parse(Console.ReadLine());
            objeto.kilometros(km);
            objeto.Imprimir();
            objeto.mensaje(km);
            
            Console.ReadKey();
            
        }
    }
}
