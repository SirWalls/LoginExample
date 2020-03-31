using System;
using System.Collections.Generic;
using System.Text;

namespace LoginExample.Services
{
    /*
          Clase sencilla para el Login
     */
    public class LoginService
    {

        //Evalua las credenciales y retorna si son válidas
        public bool Login(string user, string password)
        {
            if (user == "Usuario" && password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
    }
}
