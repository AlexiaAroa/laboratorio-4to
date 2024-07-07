using System;
namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; int cont; int ac; int op;
            do {
                do {
                    Console.Clear();
                    Console.WriteLine("Ingrese numero para factorear");
                    num = Int32.Parse(Console.ReadLine());
                } while (num <= 0);
                //n! = 1 n<=1
                cont = num; ac = num;
                while (cont > 0)
                {
                    cont = cont - 1;
                    ac = ac * cont;
                    if(cont==1){ 
                    Console.WriteLine("El resultado del factoreo es: "+ac);
                    }
                }
                Console.WriteLine("\nDesea factorear otro numero?\n1_SI\n2_NO");
                op = Int32.Parse(Console.ReadLine());
            } while (op == 1);
            Console.ReadKey();
        }
    }
}
