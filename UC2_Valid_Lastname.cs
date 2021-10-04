using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PP1_User_Registration
{
    class UC2_Valid_Lastname
    {
        public static string validationlastname = "^[A-Z]{3,}$";
        
        public bool validlname(string name)
        {
            return Regex.IsMatch(name, validationlastname);
        }
    }
}
