using System;
//La temperatura es una medida de concentración o intensidad de energía calorífica en un cuerpo. 
//Existen 4 escalas para medir la temperatura: Farenheit, Celsius, Kelvin y Ran�ine. 
//Elaborte un programa que le solicite al usuario el tipo de temperatura que desea utilizar y la temperatura como tal.
//Debe desplegar la conversión de esa temperatura en las 4 escalas anteriormente mencionadas.

namespace _2do_trimestre_ejercicios2POOix
{
    class Temperatura
    {
        private double grado,faren,celcius,kelvin,rankine;
        private int escala;
        public void Leer()
        {
            Console.WriteLine("Que tipo de escala va a utilizar??");
            Console.WriteLine("1_Farenheit"); Console.WriteLine("2_Celcius"); Console.WriteLine("3_Kelvin"); Console.WriteLine("4_Rankine");
            escala = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese grados");
            grado = int.Parse(Console.ReadLine());
        }
        public void Escalas()
        {
            switch (escala)
            {
                case 1:   //Farenheit
                    {
                        celcius=(grado-32)/1.8;
                        kelvin = ((5*(grado-32))/9)+273.5;
                        rankine = grado + 459.67;
                        Console.WriteLine("En Celsius es: "+celcius); Console.WriteLine("En Kelvin es: " + kelvin); Console.WriteLine("En Rankine es: "+rankine);
                    }
                    break;
                case 2:  //Celcius
                    {
                        faren = (grado*1.8)+32;
                        kelvin = grado + 273.15;
                        rankine = ((9 * grado) / 5)+491.67;
                        Console.WriteLine("En Kelvin es: " + kelvin); Console.WriteLine("En Rankine es: " + rankine); Console.WriteLine("En Fahrenheit es: " + faren);
                    }
                    break;
                case 3: //Kelvin
                    {
                        celcius = grado - 273.15;
                        faren = ((9 * (grado - 273.15))/5)+32;
                        rankine = ((9 * (grado - 273.15)) / 5) + 491.67;
                        Console.WriteLine("En Celsius es: " + celcius); Console.WriteLine("En Rankine es: " + rankine); Console.WriteLine("En Fahrenheit es: " + faren);
                    }
                    break;
                case 4:  //rankine
                    {
                        celcius = (5 * (grado - 491.67)) / 9;
                        faren = grado - 459.67;
                        kelvin = ((5*(grado - 491.67))/9)+273.15;
                        Console.WriteLine("En Celsius es: " + celcius); Console.WriteLine("En Kelvin es: " + kelvin); Console.WriteLine("En Fahrenheit es: " + faren);
                    }
                    break;
            }
        }
        static void Main(string[] args)
        {
            Temperatura temp = new Temperatura();
            temp.Leer();
            temp.Escalas();
            Console.ReadKey();
        }
    }
}
