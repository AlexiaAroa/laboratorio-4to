using System;
//dados,  realizar un programa que permita jugar a los dados , las reglas son:
// se tiran 3 dados, si los 3 salen con el mismo valor se debe mostrar el mensaje gano y si no, perdio :v 
namespace _2do_trimestre_ejercicio_6
{
    class Dados
    {
        private int cont = 1,dardo,cont2=1;
        public void Cargar()
        {
            while (cont <= 3)
            {
                Console.WriteLine("Ingrese numero de dados  del 1 al 10");
                dardo = int.Parse(Console.ReadLine());
                Random R = new Random();
                int num = R.Next(10);  Console.WriteLine("[{0}]", num);
                if (dardo == num)
                    cont2++;
                cont++;
            }
        } //fin cargar
        public void Comparar()
        {
            if (cont2 == 3)
                Console.WriteLine("Usted Gano");
            else
                Console.WriteLine("Usted Perdio :(");
        }
        static void Main(string[] args)
        {
            Dados D = new Dados();
            D.Cargar();
            D.Comparar();
            Console.ReadKey();
        }
    }
}