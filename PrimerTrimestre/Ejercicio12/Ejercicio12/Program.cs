using System;
namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
        string frase; int cont, cont2 = 0;  
        Console.WriteLine("Ingrese una frase");
            frase =Console.ReadLine();  //lee la frase

            for (cont = 0; cont <= frase.Length; cont++)  //frase.substring para recorrer todas las letras de la frase
            {
                if(frase.Substring(0,cont)=="a" || frase.Substring(0, cont) == "e" || frase.Substring(0, cont) == "i" || frase.Substring(0, cont) == "o" || frase.Substring(0, cont) == "u")
                    //frase.substring para comparar cada letra, una por una (del 0 a 1, 0 a 2, 0 a 3
                {
                    cont2 = cont2 + 1;
                }
                frase = frase.Remove(0, cont);
                //frase.remove para sacar los "residuos"" (en este caso las consonantes)
                cont = 0;
            }
            Console.WriteLine("La frase posee " +cont2 +" vocales");
            Console.ReadKey();
        }
    }
}