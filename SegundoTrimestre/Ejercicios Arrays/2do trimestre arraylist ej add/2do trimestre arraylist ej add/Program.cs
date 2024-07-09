using System;
using System.Collections;


namespace _2do_trimestre_arraylist_ej_add
{
    class Program
    {
        static void Main(string[] args)
        {  //inicio main
            // Create an ArrayList and add two ints.
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add(7);
            // Use ArrayList with method.
            Example(list);
            Console.ReadKey();
        }   //fin main
        static void Example(ArrayList list)
        { 
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }  //fin metodo  example
    }  //fin class
} //fin name space
