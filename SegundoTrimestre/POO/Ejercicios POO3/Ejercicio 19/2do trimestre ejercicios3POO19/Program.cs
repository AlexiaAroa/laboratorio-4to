using System;
//Realizar el diagrama de clase, la codificación en C# y el programa 
//que utilice la clase para un “Usuario” con dos atributos: 
//LoginCorrecto y PasswordCorrecto y un método: Validar(login, pass) 
//: bool, que se encargará de comparar los parámetros suministrados 
//con los valores correctos. El valor de retorno será “true” si son 
//iguales y “false” si son diferentes.

namespace _2do_trimestre_ejercicios3POO19
{
    class Usuario
    {
        private string logincorrecto, passwordcorrecto;
        public bool Validar(string login, string pass)
        {
            if (logincorrecto == login && passwordcorrecto == pass)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Usuario contra = new Usuario();
            contra.logincorrecto = "Contraseña";
            contra.passwordcorrecto = "Love";
            if (contra.Validar("Contraseña", "Love")) 
            {
                Console.WriteLine("WELCOME!");
            }
            else
                Console.WriteLine("Incorrect Password");

            Console.ReadKey();
        }
    }
}
