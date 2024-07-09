using System;
using System.Collections;

namespace _2do_trimestre_arraylist_reserve
{
    class Program
    {
        static void Main(string[] args)
        {// inicio main
         // Create an ArrayList with four strings.
         //
            ArrayList list = new ArrayList();
            list.Add("Cat");
            list.Add("Zebra");
            list.Add("Dog");
            list.Add("Cow");
            //
            // Sort the ArrayList.
            //
            Console.WriteLine("Imprime arraylist: ");

            list.Sort();
            //
            // Display the ArrayList elements.
            //
           //  Console.WriteLine("Ingresa foreach");
            foreach (string value in list)
            {  
                Console.WriteLine(value);
            } //fin foreach
            //
            // Reverse the ArrayList.
            //
            Console.WriteLine("Se repite el vector al reves");
            list.Reverse();
            //
            // Display the ArrayList elements again.
            //
            foreach (string value in list)
            {
                Console.WriteLine(value);
            } //fin foreach
            Console.ReadKey();
        } //fin main
    }
}
