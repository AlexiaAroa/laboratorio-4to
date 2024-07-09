using System;
/*Realice el diagrama de clases y la codificación en C# de las siguientes clases utilizando composición:
Un “Alumno” con Nombre, Grado y Grupo “Tiene una” “Nota Final” con Calificación y ComentarioDelProfesor.
Realice un programa que utilice la clase.*/
namespace _2do_trimestre_ejerciciosPOO2
{
    class Alumno
    {
        private string nombre;
        private int grado;
        private string comentario;
        private int nota;
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
        public string Comentario
        {
            set
            {
                comentario = value;
            }
            get
            {
                return comentario;
            }
        }
        public int Nota
        {
            set
            {
                nota = value;
            }
            get
            {
                return nota;
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
        public void imprimir()
        {
            Console.WriteLine("El alumno {0} del {1}* grado tiene un promedio final de {2}" ,nombre,grado,nota);
            Console.WriteLine("Comentario: " + comentario);
        }
    }
    class alumnos
    {
        private Alumno alumno1, alumno2, alumno3;
        public alumnos(){
            alumno1 = new Alumno();    alumno1.Nombre = "Maria"; alumno1.Nota = 9;  //no tiene saldo :v
            alumno1.Grado = 5;  /*quinto grado :v*/
            alumno1.Comentario = "MUY BIEN+";
            alumno2 = new Alumno();
            alumno2.Nombre = "Nicolas";
            alumno2.Nota = 4;
            alumno2.Grado = 7; //septimo grado :v
            alumno2.Comentario = "BIEN-";
            alumno3 = new Alumno();
            alumno3.Nombre = "Enzo";
            alumno3.Grado = 4; //tercer grado v:
            alumno3.Nota = 7;
            alumno3.Comentario = "MUY BIEN-";
        }
        public void printing()
        {
            alumno1.imprimir();
            alumno2.imprimir();
            alumno3.imprimir();
        }
        static void Main(string[] args)
        {
            alumnos alum = new alumnos();
            alum.printing();
            Console.ReadKey();
        }
    }
}
