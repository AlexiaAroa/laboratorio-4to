using System;
namespace Ejercicio7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont,num,cont3;
            Console.WriteLine("Que numero desea sacar el factorial?");
            num = Int32.Parse(Console.ReadLine());
            cont = num; cont3 = num;
            while (cont3>1){
               cont = cont * (cont3-1);
                cont3 = cont3 - 1;
            }
            Console.WriteLine("El factorial es: "+cont);
            Console.ReadKey();
        }
    }
}