using System;
using System.Collections;

namespace _2do_trimestre_arraylist_insert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList with three strings.
            ArrayList list = new ArrayList();
            list.Add("Dot");
            list.Add("Net");
            list.Add("Perls");
            // Remove middle element in ArrayList.

            list.RemoveAt(1); // It becomes [Dot, Perls]
  
                              // Insert word at the beginning of ArrayList.
                           
            list.Insert(0, "Carrot"); // It becomes [Carrot, Dot, Perls]
                                  
                                      // Remove first two words from ArrayList.
                               
            list.RemoveRange(0, 2);
            //
            // Display the result ArrayList.
            //
            foreach (string value in list)
            {
                Console.WriteLine(value); // <-- "Perls"
            }
            Console.ReadKey();
        } //fin main
    } //fin class
} // fin name space
