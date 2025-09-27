using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public static class Session
    {
        //poco seguro ésto, habría que ver como lo replanteamos
        public static UserDTO? CurrentLoggedUser = null;

        public static void LogOn(UserDTO user) => Session.CurrentLoggedUser = user;
        public static void LogOff() => Session.CurrentLoggedUser = null;
    }
}
