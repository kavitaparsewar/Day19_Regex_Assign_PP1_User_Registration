using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PP1_User_Registration
{
    class UC5_6_7_8
    {    
        public static string validationmob = "^((?=.*[a-zA-Z0-9])(?=.*[#%=]).{8,})";       
       //UC5,UC6,UC7,UC8

        public bool validation(string name)
        {
            return Regex.IsMatch(name, validationmob);
        }
    }
}
