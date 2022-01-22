using Patrones.Singleton.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EXAMEN DE SEGUNDO PARCIAL 3B//
//Desarrolle en C# un caso práctico donde se implemente el patrón singleton//
//singleton o instancia única es un patrón de diseño que permite restringir la creación de objetos pertenecientes a una clase o
//el valor de un tipo a un único objeto. Su intención consiste en garantizar que una clase solo tenga una instancia y proporcionar
//un punto de acceso global a ella.

namespace Patrones.Singleton.UIConsole
{
    class Program
    {
        //VAMOS A CREAR UN PROGRAMA EL CUAL TENGA UN USUARIO Y CONTRASEÑA
        //PARA QUE PUEDA INICIAR SESION EN UN SITIO WEB FICTICIO//
        static void Main(string[] args)
        {
            //CREAMOS USUARIO Y LA CONTRASEÑA//
           
            Usuario usuario = new Usuario();
            usuario.Username = "prueba";
            usuario.Password = "prueba";

            //CREAMOS LOGIN Y OBTENEMOS LA INSTANCIA//
            //TAMBIEN TENEMOS UN SALIR DE LA SESION//
            try
            {

                SessionManager.Login(usuario);
                
                SessionManager u = SessionManager.GetInstance;

                SessionManager.Logout();


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


         

        }
    }
}
