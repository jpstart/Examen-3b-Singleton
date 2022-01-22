using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Singleton.Core
{
    //CREAMOS UNA CLASE PUBLICA QUE SERVIRA PARA DARLE INSTANCIA APLICANDO EL PATRON DE DISEÑO "SINGLETON"//
    public class SessionManager
    {

        private static object _lock = new Object();
        private static SessionManager _session;

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");

                return _session;
            }
        }
        //CREAMOS LOS METODOS QUE SE USARAN EN LA INSTANCIA DE LA CLASE//
        

       public static void Login(Usuario usuario)
        {

            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
            }
        //CREAMOS LOS METODOS QUE SE USARAN EN LA INSTANCIA DE LA CLASE//
        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }

           
        }

        private SessionManager()
        {

        }


    }
}
