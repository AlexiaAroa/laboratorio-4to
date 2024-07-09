using System;
namespace _2do_trimestre_ejerciciosPOO1
{
    //numero abundante es .. 6+4..+3..|| es cuando es mayor ; 
    class Usuario
    {
        private string loginCorrecto;
        private string passwordCorrecto;
        public string LoginCorrecto
        {
            get
            {
                return loginCorrecto;
            }
            set
            {
                loginCorrecto = value;
            }
        }
        public string PasswordCorrecto
        {
            get
            {
                return passwordCorrecto;
            }
            set
            {
                passwordCorrecto = value;
            }
        }
        public bool Validar(string log, string pass)
        {
            if (loginCorrecto == passwordCorrecto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Usuario miUsuario = new Usuario();
         //   miUsuario.Validar();
            miUsuario.LoginCorrecto = "Administrador";  //la contraseña fija
            miUsuario.PasswordCorrecto = "Administrador";  //ingrese contraseña 
            if (miUsuario.Validar("Admin", "Administrado"))
                Console.WriteLine("Bienvenido");
            else
                Console.WriteLine("Contrasñea incorrecta");
            Console.ReadKey();
        }
    }
}