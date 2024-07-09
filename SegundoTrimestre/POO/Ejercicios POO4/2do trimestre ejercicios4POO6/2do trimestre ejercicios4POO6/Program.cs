using System;
//7.Realice una clase en C# para una Cuenta Bancaria y el programa 
//correspondiente que utilice la clase. Tomar en cuenta que:
//- La cuenta tiene un número de identificación que debe ser suministrado
//  únicamente al momento de crear un nuevo objeto.Y puede ser solamente leído 
//  al utilizar la clase.
//- La cuenta tiene un saldo.
//- El saldo puede consultarse, y solo se puede modificar dentro de la clase.
//- La única manera de modificar el saldo externamente es Depositando una cantidad 
//  o Retirando una Cantidad.
//- Al depositar, el saldo se incrementa. Al retirar, el saldo decrementa.
//  En ambos casos se notifica el depósito o retiro con un mensaje.
//- Solo se puede retirar una cantidad menor o igual al saldo actual.
//- La clase “cuenta” tiene un método para Obtener el saldo con formato moneda 
//  (regresa un string) y un método para imprimir el saldo actual.


namespace _2do_trimestre_ejercicios4POO6
{
    class CuentaBancaria
    {
        public string logincorrecto, passwordcorrecto; public int cuenta;
        public bool Validar(string login, string pass)
        {
            if (logincorrecto == login && passwordcorrecto == pass)
                return true;
            else
                return false;
        }
        public int Cuenta
        {
            set
            {
                cuenta = value;
            }
            get
            {
                return cuenta;
            }
        }

        private int sueldo, identificacion, usuario;
 
        public int Sueldos()
        {
            Console.WriteLine("Ingrese sueldo");
            sueldo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El sueldo actual es $" + sueldo);
            return sueldo;
        }
    }//fin clase CuentaBancaria
    class Program{


        static void Main(string[] args)
        {
            CuentaBancaria objeto = new CuentaBancaria();
            string login, password;
            Console.WriteLine("Write your name");
            login = (Console.ReadLine());
            Console.WriteLine("Write the password");
            password = (Console.ReadLine());

            objeto.logincorrecto = login;
            objeto.passwordcorrecto = password;
      

            if (objeto.Validar("alexia", "12345"))
            {
                Console.WriteLine("WELCOME!");
                objeto.Sueldos();
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                Console.ReadKey();
            }
   
           
            Console.ReadKey();
        }
    }
}
