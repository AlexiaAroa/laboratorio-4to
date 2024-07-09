using System;
/*3.Se ingresan 10 números. La computadora los muestra en el orden inverso del 
 que tenían al ser ingresados. */
namespace _2do_trimestre_ejercicio_array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 10; int[] vector = new int[cantidad]; bool hola = true;
            string valor = ""; int cont = 0;
            try
            {
                for (cont = 0; cont < cantidad; cont++)
                {
                    Console.Write("Ingrese nro {0}: ", cont + 1);
                    valor = Console.ReadLine();
                    vector[cont] = Convert.ToInt32(valor);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR, la cadena ingresada no es compatible");
                hola = false;
                Console.ReadKey();
            }
            if (hola == true)
            {
                Console.WriteLine();
                Console.WriteLine("Imprimir el vector al reves");
                for (cont = 10; cont > 0; cont--)
                {
                    Console.WriteLine(vector[cont - 1]);
                }
                Console.ReadKey();
            } //fin bool
        }//fin main
    }
}
