using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PP1_User_Registration
{
    class UC3_UC9_valid_email
    {
        public static string validation = "^[a-zA-Z]{3,}[.][a-zA-Z]{3,}[@][a-zA-Z]{2}[.][a-zA-Z]{2}$";
        public bool validemail(string name)
        {
            if (name == null)
            {
                throw new CustomException(CustomException.ExceptionsType.INVALID_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(name, validation);
        }
    
    }
}
