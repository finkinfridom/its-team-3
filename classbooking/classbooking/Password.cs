using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace classbooking
{
    public class Password
    {
        private static Regex createValidPasswordRegex()
        {
            string validPasswordPattern = @"^[a-zA-Z0-9_]+$";
            return new Regex(validPasswordPattern);
        }
        public static bool isValidPassword(string password)
        {
            if (password.Length < 8)
                return false;
            
            Regex validPasswordRegex = createValidPasswordRegex();
            bool isvalid = validPasswordRegex.IsMatch(password);
            return isvalid;
        }
    }
}
