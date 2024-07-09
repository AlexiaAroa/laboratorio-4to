using System;
/* 
dos dimensiones o mas dimensiones
tengo que utilizar mas for, pero por ahora solamente utilizamos 
dos dimensiones c: moverme entre filas y columnas
como puedo recorrer la matriz? entre filas o columnas como queramos
hay diferentes tipos de matrices:
3x3
2x3  tal vez lo veremos    ! 
3x2  con lozano xdxd       !
nosotros vamos a utilizar matrice cuadradas, la misma cantidad de filas y columnas
2x2 ...... 4x4 ........5x5 etc
2 diagonales, una la principal y la otra la secundaria
la principal \ es esa porque comienza desde 0,0,los indices coinciden 0,0  1,1  2,2
y la otra / es la secundaria, tiene indices distintos :v 
las dos tienen el mismo valo en el centro c:
no hay busqueda binaria, solo hay lineal
y el burbujeo es igual c: (metodo de busqueda intercambiando un valor con otro, encuentro el primer valor lo comparo con los demas y lo voy  corriendo, hasta ordenar todo)
burbujeo, burbuja, y burbuja switch c:

    como declaro la matriz? :
    float[,]TABLA= New float[3,3]; -> ejemplo
    float[,]TABLA= New float[n,m]; -> ejemplo pedido por pantalla c:

     */
namespace matrices
{
    class Program
    {
        //Esta es la funcion principal del programa
        //Aqui inicia la aplicacion 
        static void Main(string[] args)
        {
            //Variables necesarias
            int cantidad = 0; //Cantidad de alumnos 
            int salones = 0; //Cantidad de salones
            int n = 0; //Variable de control de ciclo de salones
            int m = 0; //Variable de control de ciclo de alumnos
            string valor = "";
            //variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; //variable para la calificacion minima
            float maxima = 0.0f; //variable para la calificacion maxima
            //Pedimos la cantidad de salones
            Console.WriteLine("Ingrese la cantidad de salones");
            valor=Console.ReadLine();
            salones = Convert.ToInt32(valor);
            //Pedimos la cantidad de alumnos
            Console.WriteLine("Ingrese la cantidad de alumnos por salon");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            //Creamos el arreglo
            float[,] calif = new float[salones,cantidad];
            //Capturamos la informacion 
            for (n = 0; n < salones; n++) //ciclo salones
            {
                Console.WriteLine("Salon {0}",n);
                for (m = 0; m < cantidad; m++) //Ciclo alumnos
                {
                    Console.WriteLine("Ingrese la calificacion");
                    valor = Console.ReadLine();
                    calif[n, m] = Convert.ToSingle(valor);
                } // fin ciclo alumnos
            } //fin ciclo salones
            //Encontramos el promedio
            for (n=0;n<salones;n++) //ciclo salones
            {
                for(m=0;m<cantidad;m++)//ciclo alumnos
                {
                    suma += calif[n, m];
                } //fin ciclo alumnos
            } //fin ciclo salones

            promedio = suma / (cantidad * salones);
            //Encontramos la calificacion minima
            for (n = 0; n < salones; n++) //ciclo salones
            {
                for (m = 0; m < cantidad; m++) //ciclo alumnos
                {
                    if (calif[n,m]>maxima)
                    {
                        maxima = calif[n, m];
                    }
                } //fin ciclo alumnos
            } //fin ciclo salones
            //Desplegamos los resultados 
            Console.WriteLine("El promedio es {0}",promedio);
            Console.WriteLine("La calificacion minima es {0}",minima);
            Console.WriteLine("La calificacion maxima es {0}", maxima);
            Console.ReadKey();
        } //fin main
    } //fin class
} //fin namespace

