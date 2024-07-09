using System;
//Construir un programa que lea el mes y el día y devuelva el signo zodiacal que corresponde a esa fecha.
/* Aries (21 marzo -19 abril)
 * Tauro (20 abril - 20 mayo)
 * Géminis (21 mayo - 20 junio)
 * Cáncer (21 junio - 22 julio)
 * Leo (23 julio - 22 de agosto)
 * Virgo (23 agosto - 22 setiembre)
 * Libra (23 setiembre - 22 octubre)
 * Escorpio (23 octubre - 21 noviembre)
 * Sagitario (22 noviembre - 21 diciembre)
 * Capricornio (22 diciembre - 19 enero)
 * Acuario (20 enero - 18 febrero)        ///<<< comencemos con este
 * Piscis (19 febrero - 20 marzo)
 
     */
namespace _2do_trimestre_ejercicios2POOviii
{
    class Zodiaco
    {
        private int mes, dia;
        public void Grabar()
        {
            Console.WriteLine("Ingrese mes de nacimiento");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese dia de nacimiento");
            dia = int.Parse(Console.ReadLine());
        }
        public void Comparacion()
        {
            switch (mes)
            {
                case 1:
                    {
                        if (dia <= 19) //Acuario(20 enero - 18 febrero)        ///<<< comencemos con este
                            Console.WriteLine("Usted es de Capricornio");
                        else
                            Console.WriteLine("Usted es de Acuario");
                    }
                    break;
                case 2:
                    {
                        if (dia<= 18) //Piscis(19 febrero - 20 marzo)
                        {
                            Console.WriteLine("Usted es de Acuario");
                        }else
                        {
                            Console.WriteLine("Usted es de Piscis"); 
                        }
                    }
                    break;
                case 3:
                    {
                        if (dia <= 20)
                            Console.WriteLine("Usted es de Piscis");  //Aries (21 marzo -19 abril)
                        else
                            Console.WriteLine("Usted es de Aries");
                    }
                    break;
                case 4:
                    {
                        if (dia <= 19)
                            Console.WriteLine("Usted es de Aries");  //Tauro (20 abril - 20 mayo)
                        else
                            Console.WriteLine("Usted es de Tauro");
                    }
                    break;
                case 5:
                    {
                        if (dia <= 20)
                            Console.WriteLine("Usted es de Tauro"); //Géminis (21 mayo - 20 junio)
                        else
                            Console.WriteLine("Usted es de Geminis");
                    }
                    break;
                case 6:
                    {
                        if (dia <= 20)
                            Console.WriteLine("Ustes es de Geminis");  //Cáncer (21 junio - 22 julio)
                        else
                            Console.WriteLine("Usted es de Cancer");
                    }
                    break;
                case 7:
                    {
                        if (dia <= 22)
                            Console.WriteLine("Usted es de Cancer");
                        else
                            Console.WriteLine("Usted es de Leo"); // Leo (23 julio - 22 de agosto)
                    }
                    break;
                case 8:
                    {
                        if (dia <= 22)
                            Console.WriteLine("Usted es de Leo");  //Virgo (23 agosto - 22 setiembre)
                        else
                            Console.WriteLine("Usted es de Virgo");
                    }
                    break;
                case 9:
                    {
                        if (dia <= 22)
                            Console.WriteLine("Usted es de Virgo"); //Libra (23 setiembre - 22 octubre)
                        else
                            Console.WriteLine("Usted es de Libra");
                    }
                    break;
                case 10:
                    {
                        if (dia <= 22)
                            Console.WriteLine("Usted es de Libra");
                        else
                            Console.WriteLine("Usted es de Escorpio"); //Escorpio (23 octubre - 21 noviembre)
                    }
                    break;
                case 11:
                    {
                        if (dia <= 21)
                            Console.WriteLine("Usted es de Escorpio");
                        else
                            Console.WriteLine("Usted es de Sagitario"); //Sagitario (22 noviembre - 21 diciembre)
                    }
                    break;
                case 12:
                    {
                        if (dia <= 22) // Capricornio (22 diciembre - 19 enero)
                            Console.WriteLine("Usted es de Sagitario");
                        else
                            Console.WriteLine("Ustes es de Capricornio");
                    }
                    break;
            }

            
        }
        static void Main(string[] args)
        {
            Zodiaco zikzi = new Zodiaco();
            zikzi.Grabar();
            zikzi.Comparacion();
            Console.ReadKey();
        }
    }
}
