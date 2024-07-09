using System;
namespace _2do_trimestre_ejercicios2POOxi
{
    class Perfecto
    {
        private int num, aux, div, ac = 0, aux2;
        public void grabar()
        {
            Console.WriteLine("Ingrese numero");
            num = int.Parse(Console.ReadLine());
            aux = num;
            aux = aux - 1;
        }
        public void repetir()
        {
            do
            {
                while (num % aux == 0)
                {
                    div = aux;
                    aux2 = div;
                    ac = ac + aux2;
                    break;
                }
                aux = aux - 1;
            } while (aux > 0);

        }
        public void comparacion()
        {
            if (ac == num)
            {
                Console.WriteLine("La suma de sus divisores es " + ac);
                Console.WriteLine("El numero " + num + " es perfecto");
            }
            if (ac > num)
            {
                Console.WriteLine("La suma de sus divisores es " + ac);
                Console.WriteLine("El numero " + num + " es abundante");
            }
            if (ac < num)
            {
                Console.WriteLine("La suma de sus divisores es " + ac);
                Console.WriteLine("El numero " + num + " es deficiente");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {  //inicio main
            int op, op2, cont = 0;
            do
            {
            Console.WriteLine("Que desea hacer?"); Console.WriteLine("1_Numero Perfecto"); Console.WriteLine("2_Triangulo"); Console.WriteLine("3_Salir del sistema");
            op = Int32.Parse(Console.ReadLine());
          
                switch (op)
                { //inicio switch
                    case 1:
                        {
                            Perfecto h = new Perfecto();  //ejercicio i
                            h.grabar();
                            h.repetir();
                            h.comparacion();
                        }
                        break;
                    case 2:
                        {
                            Triangulo tri = new Triangulo(); //ejercicio ii
                            tri.grabar();
                            tri.pensar();
                        }
                        break;
                    case 3:
                        Console.ReadKey();
                        break;
                }  //fin switch
                Console.WriteLine("Desea realizar otra op?");
                Console.WriteLine("1_Si        2_No");
                op2 = Int32.Parse(Console.ReadLine());
                if (op2 == 1)
                    cont++;
                else
                {
                    cont = 0;
                }

            } while (cont > 0);
        }  //fin main
    }   //fin clase perfecto ejercicio i

    class Triangulo
    {
        private int angulo, angulo2, angulo3, aux, cont = 0;
        public void grabar()
        {
            Console.WriteLine("Ingrese primer angulo");
            angulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo angulo");
            angulo2 = int.Parse(Console.ReadLine());
            aux = angulo + angulo2;
        }
        public void pensar()
        {
            if (aux < 180 && aux >= 1)
            {
                angulo3 = 180 - aux;
                cont = 0;
            }
            if (aux > 180)
                cont++;
            if (angulo <= 0 && angulo2 <= 0)
                cont++;
            if (angulo < 0 || angulo2 < 0)
                cont++;
            if (cont >= 1)
                Console.WriteLine("Esto no es un triangulo");
            else
                Console.WriteLine("El tercer angulo es: " + angulo3);
        }
    }




    }

//*using System;
/*La suma de los ángulos internos de un triángulo es de 180 grados.
 *  Crear un programa que lea 2 ángulos A y B y que determine el valor del tercer ángulo.
 *   El algoritmo deberá verificar que el tercer valor no sea cero o negativo, y si cualquiera de ellos ocurre,
 *    imprimir un mensaje de Esto No Es Un Triángulo.*/
