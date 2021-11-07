//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace PP1_User_Registration
//{
//    class UC5_6_7_8
//    {
//        //public static string validationmob = "^((?=.*[a-zA-Z0-9])(?=.*[#%=]).{8,})";
//         public static string validmobile = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[@#$%])[a-zA-Z0-9!#%^&*_+=-]{8,}$";

//        //UC5,UC6,UC7,UC8

//        public bool validation(string name)
//        {
//            if (name == null)
//            {
//                throw new CustomException(CustomException.ExceptionsType.INVALID_MESSAGE, "Invalid FirstName");
//            }
//            return Regex.IsMatch(name, validmobile);
//        }
//    }
//}
