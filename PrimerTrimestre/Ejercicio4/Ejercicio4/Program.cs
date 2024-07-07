using System;
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia; int dia2 = 0; int mes; int mes2 = 0; int mes3 = 0; int año; int año2 = 0; int cont = 10; int op;
            do {
                Console.WriteLine("Ingrese dia");
                dia = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese mes");
                mes = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese año");
                año = Int32.Parse(Console.ReadLine());
                if (año % 4 == 0 || año % 100 != 0 && año % 400 == 0)  //si es año bisiesto
                {
                    if (mes == 1) {   //  mes enero
                        if (dia == 1)  //dia 1
                        {
                            dia2 = dia + 30;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 1
                        if (dia == 31)
                        {  //dia 31
                            dia = 1;
                            mes = mes + 2;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 31
                        if (dia >= 2 && dia <= 30) { // dia de 2 a 30
                            dia = dia - 1;
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes de enero 

                    if (mes == 2)
                    {   //  mes febrero
                        if (dia >= 1 && dia <= 29)
                        { // dia de 2 a 30
                            dia = dia + 1;
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes de febrero

                    if (mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10)
                    {   //  mes restantes
                        if (dia == 1)  //dia 1
                        {
                            dia2 = dia + 30;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 1

                        if (dia >= 2 && dia <= 31)
                        { // dia de 2 a 30
                            dia = dia - 1;
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes restantes

                    if (mes == 12)
                    {   //  mes restantes
                        if (dia == 1)  //dia 1
                        {
                            dia2 = dia + 30;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 1

                        if (dia >= 2 && dia <= 31)
                        { // dia de 2 a 30    
                            dia = dia - 1;
                            mes3 = 1;
                            año2 = año + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes3);
                            Console.WriteLine("Año: " + año2);
                        } //dia de 2 a 30 
                    }  //fin mes restantes

                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {   //  mes restantes
                        if (dia == 1)  //dia 1
                        {
                            dia2 = 1;
                            mes2 = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes2);
                            Console.WriteLine("Año: " + año);
                        } //dia 1
                        if (dia >= 2 && dia <= 30) { // dia de 2 a 30
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes restantes
                }   //comparacion año bisiesto

                if (año % 4 != 0 || año % 100 == 0 && año % 400 != 0)
                {
                    if (mes == 1)
                    {   //  mes enero
                        if (dia == 1)  //dia 1
                        {
                            dia2 = dia + 30;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 1
                        if (dia == 31)
                        {  //dia 31
                            dia = 2;
                            mes = mes + 2;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 31
                        if (dia >= 2 && dia <= 30)
                        { // dia de 2 a 30
                            dia = dia - 1;
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes de enero 
                    if (mes == 2)
                    {   //  mes febrero
                        if (dia >= 1 && dia <= 28)
                        { // dia de 2 a 30
                            dia = dia + 2;
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 28
                    }  //fin mes de febrero

                    if (mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10)
                    {   //  mes restantes
                        if (dia == 1)  //dia 1
                        {
                            dia2 = dia + 30;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 1

                        if (dia >= 2 && dia <= 31)
                        { // dia de 2 a 30
                            dia = dia - 1;
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes restantes

                    if (mes == 12)
                    {   //  mes restantes
                        if (dia == 1)  //dia 1
                        {
                            dia2 = dia + 30;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia 1

                        if (dia >= 2 && dia <= 31)
                        { // dia de 2 a 30    
                            dia = dia - 1;
                            mes3 = 1;
                            año2 = año + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes3);
                            Console.WriteLine("Año: " + año2);
                        } //dia de 2 a 30 
                    }  //fin mes restantes
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {   //  mes restantes
                        if (dia == 1)  //dia 1
                        {
                            dia2 = 1;
                            mes2 = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia2);
                            Console.WriteLine("Mes: " + mes2);
                            Console.WriteLine("Año: " + año);
                        } //dia 1
                        if (dia >= 2 && dia <= 30)
                        { // dia de 2 a 30
                            mes = mes + 1;
                            Console.WriteLine("Sumando 30 dias la nueva fecha es: ");
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("Mes: " + mes);
                            Console.WriteLine("Año: " + año);
                        } //dia de 2 a 30 
                    }  //fin mes restantes
                }
                dia = 0;
                dia2 =0;
                mes = 0;
                mes2 = 0;
                mes3 = 0;
                año = 0;
                año2 = 0;
                do {
                    Console.WriteLine("Desea ingresar otra fecha?");
                    Console.WriteLine("1_SI    2_NO");
                    op = Int32.Parse(Console.ReadLine());
                    if (op == 1)
                        cont = cont + 1;
                    if (op == 2)
                        cont = 1;
                } while (op!=1 && op!=2);
            } while (cont>=10);
                Console.ReadKey();
        }
    }
}