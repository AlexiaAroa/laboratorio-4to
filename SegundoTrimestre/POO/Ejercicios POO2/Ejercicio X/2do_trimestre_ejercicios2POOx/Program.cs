using System;
//Para calcular el impuesto de la renta de una persona en nuestro país se hace de la siguiente forma:
//1.	Toda persona que gane entre 468000 y 702000 debe pagar un 10% de impuesto.Sobre la diferencia de su salario con respecto al limite
//2.	Toda persona que gane mas de 702000 debe pagar un 15% de impuesto. Sobre la diferencia de su salario con respecto al limite
//1.	Por ejemplo si una persona gana 750000 colones mensuales, debe pagar:
//1.	234000 * 10% y (como esta persona abarca todo el primer limite)
//2.	48000 * 15% y
//3.	Sumar ambos resultados.
//3.	Adicionalmente al resultado se le debe restar 1300 si es casado legalmente y 880 por cada hijo que tenga.
// 5. Hacer un programa que calcule el monto a pagar por impuesto de renta de una persona.Para lo cual debe capturar el salario mensual,
//indicar si es casado o no, numero de hijos.V desplegar el monto a pagar.


namespace _2do_trimestre_ejercicios2POOx
{
    class Impuestos
    {
        private int plata, promedio, promedio2, total, casado, hijos,number;
        public void Pregunta()
        {
            Console.WriteLine("How much money do you have for job?");
            plata = int.Parse(Console.ReadLine());
            
                Console.WriteLine("Have you got a wife or a husband?"); Console.WriteLine("1_YES   2_NO");
                casado = int.Parse(Console.ReadLine());
                Console.WriteLine("Have you got children?"); Console.WriteLine("1_YES   2_NO");
                hijos = int.Parse(Console.ReadLine());
                if (hijos == 1)
                {
                    Console.WriteLine("How many children do yo have?");
                    number = int.Parse(Console.ReadLine());
                }

            
        }

        public void Pagar()
        {
            if (plata >= 468000)
                promedio = (10*plata)/100;   //el 10% 
            if (plata >= 702000)
                promedio2 = (plata * 15)/100;  // el 15%
            if (plata < 468000)
            
                Console.WriteLine("Usted no paga impuestos");
   
            total = promedio2 + promedio;
        }     
        public void Married()
        {
            if (casado == 1)
                total = total - 1300;
            if (plata >= 468000)
            {
                if (hijos == 1)
                    total = total - (880 * number);
            }
            else
                total = 0;
        }
        public void datos()
        {
            Console.WriteLine("Usted gana: "+plata+ " pesos");
            if (casado == 1)
                Console.WriteLine("Está casado");
            else
                Console.WriteLine("No está casado");
            if (hijos == 1)
                Console.WriteLine("Usted tiene " + number + " hijos");
            else
                Console.WriteLine("No tiene hijos");
            Console.WriteLine("Usted debe pagar: " + total + " pesos");
        }
        static void Main(string[] args)
        {
            Impuestos pague = new Impuestos();
            pague.Pregunta();
            pague.Pagar();
            pague.Married();
            pague.datos();
            Console.ReadKey();
        }
    }
}
