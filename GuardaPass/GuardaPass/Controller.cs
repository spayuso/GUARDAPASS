using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardaPass
{
    class Controller
    {
        public String nombreUsuario { get; set; }
        public String password { get; set; }


        public void CrearNuevoUsuario(String nom, String pass)
        {
            Console.WriteLine("Introduzca nombre de usuario");
            nombreUsuario = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca password de usuario");
            password = Convert.ToString(Console.ReadLine());
        }

        public Boolean Login(String nom, String pass)
        {
            if (nom == nombreUsuario && pass == password)
            {
                return true;
            }
            else
                return false;
        }

        public Boolean AnadirContrasena()
        {
            return true;
        }

        public Boolean ListarContrasena()
        {
            return true;
        }
    }
}
