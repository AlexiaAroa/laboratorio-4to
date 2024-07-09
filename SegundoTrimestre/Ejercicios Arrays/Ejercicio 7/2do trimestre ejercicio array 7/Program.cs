using System;
//7.Se ingresan 10 apellidos. La computadora los muestra ordenados 
//alfabéticamente. 
namespace _2do_trimestre_ejercicio_array_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Apellidos = new string[10]; bool h = true;
            try
            {
                for (int a = 0; a < Apellidos.Length; a++)
                {
                    Console.Write("Ingrese Apellido [{0}]:", a + 1);
                    Apellidos[a] = Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR");
                h = false;
            }
            // Console.Clear();
            if (h == true)
            {
                Console.WriteLine("Ordenados Alfabeticamente:");
                for (int a = 0; a < 9; a++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (Apellidos[i].CompareTo(Apellidos[i + 1]) > 0)
                        {
                            string Aux;
                            Aux = Apellidos[i];
                            Apellidos[i] = Apellidos[i + 1];
                            Apellidos[i + 1] = Aux;
                        }
                    }
                }
                //   Console.Clear();

                for (int a = 0; a < Apellidos.Length; a++)
                {
                    Console.WriteLine("{0}. {1}", a + 1, Apellidos[a]);
                }
            }
            Console.ReadKey();
        }//fin main
    }
}
/*
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
            Console.Write("La frase posee ");
            Console.Write(cont2);
            Console.WriteLine(" vocales");
            Console.ReadKey();
     */
