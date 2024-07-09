using System;
//Realice el diagrama de clases y la codificación en C# de las siguientes
//clases utilizando composición: Un “Alumno” con Nombre, Grado y Grupo 
//“Tiene una” “Nota Final” con Calificación y ComentarioDelProfesor.
//Realice un programa que utilice la clase.
namespace _2do_trimestre_ejercicios3POO20
{
    class Notas
    {
        public int calificacion; public string comentariodelprofesor;
        public int Calificacion
        {
            set
            {
                calificacion = value;
            }
            get
            {
                return calificacion;
            }
        }
         public string Comentariodelprofesor
        {
            set
            {
                comentariodelprofesor = value;
            }
            get
            {
                return comentariodelprofesor;
            }
        }   
     }
    class Alumno
    {
        public string nombre,grupo; public int grado;
        public Notas notafin = new Notas();
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Grado
        {
            set
            {
                grado = value;
            }
            get
            {
                return grado;
            }
        }
        public string Grupo
        {
            set
            {
                grupo = value;
            }
            get
            {
                return grupo;
            }
        }
        public Notas notafinal
        {

            get
            {
                return notafinal;
            }
            set
            {
                notafinal = value;
            }
         
        }

        public void Imprimir()
         {
           Console.WriteLine("Nombre: " + nombre);
         Console.WriteLine("Grado: " + grado);
           Console.WriteLine("Grupo: " + grupo);
            Console.WriteLine("Nota final: " + notafin.calificacion);
            Console.WriteLine("Comentario: "+notafin.comentariodelprofesor);

         }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno student = new Alumno();
            student.Nombre = "Alfredo";
            student.Grado = 7;
            student.Grupo = "A";
            student.notafin.calificacion = 9;
            student.notafin.comentariodelprofesor = "Excelente";
            student.Imprimir();
            Console.ReadKey();

        }
    }   
}
