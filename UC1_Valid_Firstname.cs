using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PP1_User_Registration
{
    class UC1_Valid_Firstname
    {
        public static string validationfirstname = "^[A-Z]{3,}$";
        public bool validfname(string name)
        {
            return Regex.IsMatch(name, validationfirstname);
        }
    
    }
 }
