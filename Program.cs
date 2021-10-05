using System;

namespace PP1_User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region start UC1   
            //UC1_Valid_Firstname UC1 = new UC1_Valid_Firstname();
            //Console.WriteLine(UC1.validfname("KAVITA"));
            //#endregion UC1

            //#region start UC2   
            //UC2_Valid_Lastname UC2 = new UC2_Valid_Lastname();
            //Console.WriteLine(UC2.validlname("PARSEWAR"));
            //#endregion UC2


            //#region start UC3_UC9   
            //UC3_UC9_valid_email UC3 = new UC3_UC9_valid_email();
            //Console.WriteLine(UC3.validemail("abc.xyz@in.bl"));
            //#endregion UC3_UC9

            //#region start UC4
            //UC4_mobile_format UC4 = new UC4_mobile_format();
            //Console.WriteLine(UC4.validmobile("91 9919819801"));
            //#endregion UC4

            #region start UC5,UC6,UC7,UC8
            UC5_6_7_8 pattern = new UC5_6_7_8();
            Console.WriteLine(pattern.validation("abcdAfgh@1"));                 
            #endregion UC5,UC6,UC7,UC8

        }
    }
}
