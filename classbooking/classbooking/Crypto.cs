using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace classbooking
{
    static public class Crypto
    {
        static public string crypto(string value)
        {
            using (SHA1CryptoServiceProvider password = new SHA1CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = password.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }

        }
    }
}
