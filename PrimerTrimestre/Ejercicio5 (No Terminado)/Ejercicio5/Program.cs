using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int año, mes, dia, dia2, mes2, dia3, año2, año3, mes3, ac, diaactual = 10, mesactual = 5, añoactual = 2018;
             
       
            Console.WriteLine("INGRESE SU FECHA DE NACIMIENTO");
            do
            {
                Console.WriteLine("Primero ingrese el año");
                año = Int32.Parse(Console.ReadLine());
            } while (año < 0 || año > 2100);

            Console.WriteLine("Ahora ingrese el mes");
            mes = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Y ahora ingrese el dia");
            dia = Int32.Parse(Console.ReadLine());

            if (mes > 5)
            {
                año2 = (2018 - año) - 1;
                año3 = año2 * 365;
                if (mes == 8)
                {
                    mes3 = mes * 30;
                    if (dia <= 20)
                    {
                        dia3 = dia + 10;
                        ac = año3 + mes3 + dia3;
                        Console.Write("Los dias vividos son: ");
                        Console.WriteLine(ac);
                    }

                }
                if (mes == 9)
                {
                    mes3 = 7 * 30;
                    if (dia <= 20)
                    {
                        dia3 = dia + 10;
                        ac = año3 + mes3 + dia3;
                        Console.Write("Los dias vividos son: ");
                        Console.WriteLine(ac);
                    }
                }
                    if (mes == 10)
                    {
                        mes3 = 6 * 30;
                        if (dia <= 20)
                        {
                            dia3 = dia + 10;
                            ac = año3 + mes3 + dia3;
                            Console.Write("Los dias vividos son: ");
                            Console.WriteLine(ac);
                        }

                    }
                if (mes == 11)
                {
                    mes3 = 5 * 30;
                    if (dia <= 20)
                    {
                        dia3 = dia + 10;
                        ac = año3 + mes3 + dia3;
                        Console.Write("Los dias vividos son: ");
                        Console.WriteLine(ac);
                    }

                }
                        if (mes == 12)
                        {
                            mes3 = 4 * 30;
                            if (dia <= 20)
                            {
                                dia3 = dia + 10;
                                ac = año3 + mes3 + dia3;
                                Console.Write("Los dias vividos son: ");
                                Console.WriteLine(ac);
                            }
                        }
                    }


            Console.ReadKey();
        }
    }
}
