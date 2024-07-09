/*
 Que son las colecciones de clases en C#? La colecciones de clases de C# son 
 un conjunto de clases diseñadas específicamente para agrupar objetos y llevar 
 a cabo tareas con ellos. 

 Tanto la list<T> ArrayList y las clases tienen propiedades muy similares a los 
 arrays de C# (para más detalles sobre estos busquen informacion sobre matrices 
 en C#). Una ventaja fundamental de estas clases sobre los arrays es que puedan 
 crecer y reducir el número de objetos almacenados.
 
La list<T> clase en contenida en System.Collections.Generic, mientras que la 
clase ArrayList figura en el System.Collections.

La sintaxis para crear una colección list<T> es la siguiente:

List<type> nombre = new List<type>(); ArrayList es un objeto creado de una manera
similar, aunque sin el argumento de tipo:
ArrayList nombre = new ArrayList (); 
Con esta sintaxis ahora podemos crear una list<T> denominada colorlist:using System;
using System.Collections.Generic;
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_trimestre_arraylist_ejemplos
{
    public class Lists
    {
        static void Main()
        {
            List<string> colorList = new List<string>();
        }
    }
}


//falta mas jsajsaj carpeta arraylist ejemplo2