using System;
//vamos a ver excepciones, cuando el usuario ingresa errores
//ejemplo si el usuario dice que se divida por cero, que aparezca
//un cartel que diga que no se puede hacer, etc
//que es un vector :v 
/* ejemplo , alguno en su casa tiene una cajonera ? xdxd
 supongamos que yo tengo la cajonera aca, supongamos que un vector (array) es una
  cajonera que puedo pner diferentes cosas. 
  un vector es una posicion de memoria que contiene diferentes cajones , que me 
  permite almacenar datos del mismo tipo
 un vector 
 tarea:¿ puedo tener un vector de string?, si se puede v: alv xD
 ¿se puede tener un string, pero puedo almacenar una letra y un número ??
 puedo poner un decimal , double, float como tipo de dato del vector ?: no se puede 
 xdxd,el vector tiene un indice
 el indice si o si es entero, l variable que yo voy a utilizar como indice en ese 
 vector es entero
 por eso es entero, sino seria infinito 
 el tipo de dato que yo almacen, puede ser int , string u otro tipo de datos
 el indice tiene que ser entero y 
 ¿que diferencia hay entre elemento y posicion?
 elemento es lo que guardas, y la posicion es la ubicacion
 el elemento es lo que yo almaceno y la posicion es el indice que me permite moverme

vector,  8, 5, 2 , 5
el elemento es 2, pero la posicion es 3 ... c:

 para definir el vector tengo que definir el tipo, y la cantidad de elementos xdxd
 arreglos estaticos y de una dimension.
 vectores estaticos eso veremos xdxd
 luego veremos vectores dinaminos
 diferencia: array list y un estatico es que el vector una vez que lo defini no puedo
 modificar su tamaño, array list me permite modificar el tamaño del vector

    tipo[] nombre = new tipo [tamaño]
    ejemplo:
    float[]calificaciones = new float [10]
    indice char o int, no more 
    para recorrer un vector utilizamos un for c:
    si bien puedo cargar 10 numeros, en vez de cargar de 10 variables,
    pongo un vector de 10 posiciones, pero tengo que hacer 2 cosas
   tengo que utilizar 2 for
   1_para cargarlo
   2_para mostrar 

   tambien para recorrer c:
   y no se que mas dijo xdxd


   */
namespace tema_2__vectores_y_matrices
{
    class Program
    {
        //Esta es la funcion principal del programa
        //Aqui inicia la aplicacion
        static void Main(string[] args)
        {
            //variables necesarias
            int cantidad = 0; //cantidad de alumnos
            int n = 0; //variable de control de ciclo
            string valor = "";
            //variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; //variable para la calificacion minima 
            float maxima = 0.0f; // variable para la calificacion maxima
            //Pedimos la cantidad de alumnos
            Console.WriteLine("Ingrese la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            //creamos el arreglo
            float[] calif = new float[cantidad];
            //capturamos la informacion
            for (n = 0; n < cantidad; n++)
            {
                Console.Write("Dame la calificacion ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }
            //encontramos el promedio
            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }
            promedio = suma / cantidad;
            //Encontramos la calificacion minima
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] < minima)
                {
                    minima = calif[n];
                }
            }
            //Encontramos la calificacion maxima
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] > maxima)
                {
                    maxima = calif[n];
                }
            }
            //Desplegamos los resultados
            Console.WriteLine("El promedio {0}",promedio);
            Console.WriteLine("La calificacion minima es {0}", minima);
            Console.WriteLine("La calificacion maxima es {0}",maxima);
            Console.ReadKey();
        }//cierre de main
    }//cierre de la clase
}

//un vector tiene varios metodos para poder arreglarlo
//burbuja, burjuta swith, sehra, el mas facil es el burbuja
//buscarlo en la casa xdxd
//busqueda lineal y binaria <- busqueda del elemento

//busqueda binaria= senmentar el parte, por ejmeplo busco la pagina 250, lo qu hace la busqueda lineal es buscar uno por uno, y hace 250 pasos, la busqueda binaria busca el principio y el final y calcula el medio, o sea que del total (380 paginas), se divide dos, 190 , ese es el medio, 250 es mayor de 190? si, por lo que empieza a analisar de 190, luego,, hace la mitad de ... cada vez va separando a la mitad, va acortando el camino xdxd, jiji, 
//pero para realizar la busqueda binaria el vector tiene que estar ordenado los elementos xdxd. para realizar las comparacions
