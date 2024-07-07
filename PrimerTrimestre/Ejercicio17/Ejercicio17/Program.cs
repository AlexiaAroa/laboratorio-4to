using System;
namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int pre; int gine, trau, pedi;
            do
            {
                Console.WriteLine("Ingrese presupuesto");
                pre = Int32.Parse(Console.ReadLine());
            } while (pre <= 0);
            gine = (40 * pre) / 100;
            Console.Write("El presupuesto en ginecologia es: "+ gine);
            trau = (30 * pre) / 100;
            Console.Write("El presupuesto en traumatologia es: "+trau);
            pedi = (30 * pre) / 100;
            Console.Write("El presupuesto en pediatria es: "+pedi);
            Console.ReadKey();
        }
    }
}