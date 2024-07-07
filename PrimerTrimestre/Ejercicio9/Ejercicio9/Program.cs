using System;
namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase="*"; int cont3;int cont4 = 2;
            for (cont3 = 0; cont3 <= 4; cont3++) { 
                do
                {
                    Console.WriteLine(frase);
                    cont4 = cont4 - 1;
                } while (6 <= 1);
                frase = frase + "**";
            }
            Console.ReadKey();
        }
    }
}

/*  OTRA CLASE DE ARBOL:
           string hola = ""; int cont; 
           for (cont=1; cont<=5; cont++)
           {
               hola =  hola + "*";
               Console.WriteLine(hola);
           }*/
