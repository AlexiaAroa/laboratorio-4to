using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Diseña una clase alumno en la cual se incluya la nota media para ingresar a la universidad y
//tenga en cuenta la nota de cuenta para q entre como alumno a la escuela de ingeniería   

namespace _2do_trimestre_ejercicios3POO17
{
    class Alumno
    {
        public int nota; private string nombre; 
        private string Nombre
        {
            set
            {
                value = nombre;
            }
            get
            {
                return nombre;
            }
        }
        public int Nota
        {
            set
            {
                if (value >= 6)
                {
                    Console.WriteLine("Puedes ingresar a la universidad");
                    if (value >= 9)
                    {
                        Console.WriteLine("Usted puede ser estudiante en la escuela de ingeniería");
                    }
                    nota = value;
                }
                else
                {
                    Console.WriteLine("No puedes ingresar a la Universidad");
                    nota = value;
                }
            }
            get
            {
                return nota;
            }
        }
        static void Main(string[] args)
        {
            Alumno study = new Alumno();
            study.nombre = "Alejo";
            study.Nota = 3;
            Console.WriteLine("Nombre: " + study.nombre);
            Console.WriteLine("Resultados: "+study.Nota);
            Console.ReadKey();
        }
    }
}
