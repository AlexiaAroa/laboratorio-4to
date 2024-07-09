/*es una lista y ademas tiene, la diferencia del array, tiene--
en la ejecucion puedo cambiar el tamaño cuando quiera
en el array no puedo cambiar el tamaño, bueno solo el usuario no puede
a medida que pasa el  programa puedo agregar o quitar elementos
en el array comun podia eliminar los elementos pero el array va a tener la misma
cantidad de posiciones

    ArrayList datos = new ArrayList();
    ArrayList datos = new ArrayList(32);

    para agregar el elemento al final de la lista
    datos.ADD(nro que quiero agregar);

    datos.Insert(2,5);  lo que hace es meter un elemento (insert) 
    el add tambien agrega un elemento pero al final
    el insert , corre todo el vector (en este caso) porque lo quiero poner
    en la posicion dos

    si quiero eliminar un elemento:
    datos.RemoveAt(3); elimina el que esta en la posicion 3... borra el??
    borra el elemento o wtf 

    para ver si el valor está o no está
    datos.Indexof(7);
    Busca el objeto Object especificado y devuelve el índice de base cero de 
    la primera aparición en toda la colección ArrayList.

    busca el elemento o el indice ???  ._. , si no esta la posicion solo
    te devuelve un -1 y no more (?(?
    busco el elemento


    siempre que recorro un arraylist, necesito usar un foreach 
    lo que permite es lo mismo que el for pero .. reccore del primero al ultimo
    no hay un condicion, los recorre a todos, si tengo 500 los recorre a los 500

    foreach(tipo identificador in  expression)
    Sentencia

    foreach(int valor in costo)
    {
      Console.WriteLine("El valor es {0}", valor);
    }

 */
using System;
using System.Collections;
namespace _2do_trimestre_array_list
{
    public class SamplesArrayList
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}

//pila y cola, voy apilando y sale el primero,  luego el ultimo, y bue c:
//  .com   <- cuenta la cantidad de elementos
/*
 elementos=datos.count;    en el foreach c:

     */