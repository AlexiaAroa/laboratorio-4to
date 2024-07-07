using System;
namespace Ejercicio16Double
{
    class Program
    {
        static void Main(string[] args)
        {
            double articulo, pagar, cien = 0, doscientos = 0, quinientos = 0, resto, cincuenta = 0, veinte = 0, diez = 0, cinco = 0, dos = 0, uno = 0, monedacincuenta = 0, monedaveinte = 0, monedacinco = 0, monedadiez = 0;
            Console.WriteLine("Ingrese precio del articulo");
            articulo = double.Parse(Console.ReadLine());  

            Console.WriteLine("Ingrese dinero a pagar");
            pagar = double.Parse(Console.ReadLine());

            resto = pagar - articulo;
            Console.WriteLine("El vuelto total es de $" + resto+"\n");
            do
            {
                if (resto >= 500)
                {
                    resto = resto - 500;
                    quinientos = quinientos + 1;
                }
            } while (resto >= 500);
            if (quinientos > 0) 
            Console.Write("Su vuelto es de " + quinientos+ " billetes de $500\n");
            //______________________________________________________________________________
            do
            {
                if (resto >= 200)
                {
                    resto = resto - 200;
                    doscientos = doscientos + 1;
                }
            } while (resto >= 200);
            if (doscientos > 0)           
                Console.Write("Su vuelto es de " + doscientos+ " billetes de $200\n");   
            //_______________________________________________________________________________
            do
            {
                if (resto >= 100)
                {
                    resto = resto - 100;
                    cien = cien + 1;
                }
            } while (resto >= 100);
            if (cien > 0)
                Console.Write("Su vuelto es de " + cien+" billetes de $100\n");
            //_______________________________________________________________________________
            do
            {
                if (resto >= 50)
                {
                    resto = resto - 50;
                    cincuenta= cincuenta + 1;
                }
            } while (resto >= 50);
            if (cincuenta > 0)
                Console.Write("Su vuelto es de " + cincuenta+ " billetes de $50\n");
            //_______________________________________________________________________________
            do
            {
                if (resto >= 20)
                {
                    resto = resto - 20;
                    veinte = veinte + 1;
                }
            } while (resto >= 20);
            if (veinte > 0)
                Console.Write("Su vuelto es de " + veinte+ " billetes de $20\n");
            //______________________________________________________________________________
            do
            {
                if (resto >= 10)
                {
                    resto = resto - 10;
                    diez = diez + 1;
                }
            } while (resto >= 10);
            if (diez > 0)
                Console.Write("Su vuelto es de " + diez+ " billetes de $10\n");
            //_______________________________________________________________________________
            do
            {
                if (resto >= 5)
                {
                    resto = resto - 5;
                    cinco = cinco + 1;
                }
            } while (resto >= 5);
            if (cinco > 0)
                Console.Write("Su vuelto es de " + cinco+ " billetes de $5\n");
            //_____________________________________________________________________________
            do
            {
                if (resto >= 2)
                {
                    resto = resto - 2;
                    dos = dos + 1;
                }
            } while (resto >= 2);
            if (dos > 0)
                Console.Write("Su vuelto es de " + dos+ " monedas de 2 pesos\n");
            //_____________________________________________________________________________
            do
            {
                if (resto >= 1)
                {
                    resto = resto -1;
                    uno = uno + 1;
                }
            } while (resto >= 1);
            if (uno > 0)
                Console.Write("Su vuelto es de " + uno+ " monedas de 1 peso\n");
            //___________________________________________________________________________
            do
            {
                if (resto >= 1)
                {
                    resto = resto - 1;
                    uno = uno + 1;
                }
            } while (resto >= 1);
            if (uno > 0)
                Console.WriteLine("Su vuelto es de " + uno+ " monedas de 1 peso");
            //_________________________________________________________________________
            do
            {
                if (resto >= 0.50)
                {
                    resto = resto - 0.50;
                    monedacincuenta = monedacincuenta + 1;
                }
            } while (resto >= 0.50);
            if (monedacincuenta > 0)
                Console.WriteLine("Su vuelto es de " + monedacincuenta+ " monedas de 50 centavos");
            //_______________________________________________________________________
            do
            {
                if (resto >= 0.25)
                {
                    resto = resto - 0.25;
                    monedaveinte = monedaveinte + 1;
                }
            } while (resto >= 0.25);
            if (monedaveinte > 0)
                Console.WriteLine("Su vuelto es de " + monedaveinte+ " monedas de 25 centavos");
            //____________________________________________________________________
            do
            {
                if (resto >= 0.10)
                {
                    resto = resto - 0.10;
                    monedadiez = monedadiez + 1;
                }
            } while (resto >= 0.10);
            if (monedaveinte > 0)
                Console.WriteLine("Su vuelto es de " + monedadiez+ " monedas de 10 centavos");
            //____________________________________________________________________________
            do
            {
                if (resto >= 0.05)
                {
                    resto = resto - 0.05;
                    monedacinco = monedacinco + 1;
                }
            } while (resto >= 0.05);
            if (monedaveinte > 0)
                Console.Write("Su vuelto es de " + monedacinco+ " monedas de 5 centavos");
            Console.ReadLine();
        }
    }
}