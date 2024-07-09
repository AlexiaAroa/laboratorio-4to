using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dotrimTareaMetodoOrdenamientoBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; int m=0; int g = 0; //Variabls enteras
            int[] nums;//Arreglo sin definir tamaño
            Console.WriteLine("Ingrese cantidad de numeros: "); //Imprime en pantalla la orden al usuario
            n = int.Parse(Console.ReadLine());// Lee el valor digitado por el usuario y lo convierte en entero
            nums = new int[n]; //Dimensiona el arreglo del tamaño que el usuario digitó
            for (int d=0;d<n;d++) //For que va dede el inicio hasta el final del arreglo
            {
                Console.Write("Escribe el numero [{0}]: ", d);  //Imprme en pantalla la orden al usuario
                nums[d] = int.Parse(Console.ReadLine()); //Lee el dato digitado por el usuario y lo convierte a entero, en la posicion del arreglo actual
            }

            //METODO BURBUJA INICIA

            for(int x=1; x < n; x++) //primer for que va desde la segunda poicion hata el final
            {
                for(int y = 0; y < (n - 1); y++) //Segundo for que va desde la primera posicion hasta el final menos una 
                {
                    if (nums[x] < nums[y]) //Condicion que definira si le ordenamos mayor a menor, o de menor a mayor
                    {
                        m = nums[x]; //Variable de apoto para conservar los valores antes de cambiarlos
                        nums[x] = nums[y]; //Cambio de valores de x
                        nums[y] = m; //Cambio de valores de y
                    }
                }
            } //fin for x

            //METODO DE BURBUJA TERMINA

            for(int r=0; r < n; r++) //For de salida
            {
                Console.WriteLine("{0}.- {0}", r+1,nums[r]); //Salida con la nueva orden
            }
            Console.ReadKey(); //Pausa
        }
    }
}
