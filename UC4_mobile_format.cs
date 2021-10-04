using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PP1_User_Registration
{
    class UC4_mobile_format
    {
        public static string validation = "^[91]+[ ]+[0-9]{10}$";
        public bool validmobile(string name)
        {
            return Regex.IsMatch(name, validation);
        }
    }
}
