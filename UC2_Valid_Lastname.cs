using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PP1_User_Registration
{
    class UC2_Valid_Lastname
    {
        public static string validationlastname = "^[A-Z]{1}[a-z]{2,}$";

        public bool validlname(string name)
        {
            if (name == null)
            {
                throw new CustomException(CustomException.ExceptionsType.INVALID_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(name, validationlastname);
        }
    }
}
