using System;
namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "*"; int cont3; int cont4 = 2; int altura2; int cont=2;

            Console.WriteLine("Ingrese altura de la piramede");
            altura2 = Int32.Parse(Console.ReadLine());
            for (cont3 = 0; cont3 <= (altura2-1); cont3++)
            {
                do
                {
                    Console.WriteLine(frase);
                    cont4 = cont4 - 1;
                } while (cont <= 1);
                frase = frase + "**";
            }

            Console.ReadKey();
        }
    }
}

//  string hola = "";
//  int cont; int altura; int op; int cont2 = 0;
//  do
//  {
//    Console.WriteLine("Ingrese altura de la piramide");
//  altura = Int32.Parse(Console.ReadLine());
//    Console.WriteLine();
//    for (cont = 1; cont <= altura; cont++)
//     {
//       hola = hola + "*";
//     Console.WriteLine(hola);
//          }
//        Console.WriteLine("Desea realizar otra piramide?");
//      Console.WriteLine("1_SI     2_NO");
//    op = Int32.Parse(Console.ReadLine());
//  if (op == 1)
//              {
//                cont2 = cont2 + 2;
//              cont = 1;
//        }
//   } while (cont > 0);

//·······················································································

