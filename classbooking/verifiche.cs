using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classbooking
{
    static public class Verifiche
    {
        static public Boolean verificaEmail(string email)
        {
            int chiocciola = email.IndexOf('@');
            int punto = email.LastIndexOf('.');
            if (chiocciola < 0 || punto < chiocciola || email.Length-punto<2)
                return false;

            return true;
        }

        static public Boolean verificaPassword(string password)
        {
            if (password.Length < 5)
                return false;

            return true;
        }
    }
}
