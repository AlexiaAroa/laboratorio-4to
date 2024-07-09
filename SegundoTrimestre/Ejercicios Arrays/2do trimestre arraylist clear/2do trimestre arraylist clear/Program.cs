using System;
using System.Collections;

namespace _2do_trimestre_arraylist_clear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList with two values.
          
            ArrayList list = new ArrayList();
            list.Add(9);
            list.Add(10);
            // Show number of elements in ArrayList.
            Console.WriteLine(list.Count);
            Console.WriteLine("Continue clear");
            // Clear the ArrayList.
            list.Clear();
            // Show count again.
            Console.WriteLine(list.Count);
            Console.ReadKey();
        }
    }
}
