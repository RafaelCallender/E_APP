using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.USER_VIEW.USER_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.Win32.NativeMethods;
using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;

namespace E_APP.VIEW.USER_VIEW.USER_SELECTION_VIEW
{
    internal class User_Selection_View03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Services01 Sql_Serv01= new Sql_Services01();     
        public User_Selection_View03()
        {
            load_User_Selection_View03();
        }
        private void load_User_Selection_View03()
        {

            data01[0] = $"1.) forgot username \n" +
                         $"2.) go back";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                if (Security_Serv01.empty_string(data01[1]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                               data01[2] = "Email Address";
                                Console.WriteLine(data01[2]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    string sqlouput= string.Empty;  
                                    if (Sql_Serv01.find_username_using_email(data01[3], out sqlouput))
                                    {
                                        data01[2] = $"Your username is {sqlouput}";
                                        Console.WriteLine(data01[2]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;


                                    }
                                    else
                                    {
                                        data01[2] = sqlouput;
                                        Console.WriteLine(data01[2]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }
                                }
                                else
                                {
                                    data01[2] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[2]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                             
                            case 2:
                                new User_Main_View01();
                                return;



                        }
                    }
                    else
                    {


                        data01[2] = "Input must be only digits. Please try again.";
                        Console.WriteLine(data01[2]);
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {
                    data01[2] = "Input cannot be empty. Please try again.";
                    Console.WriteLine(data01[2]);
                    data01[1] = Console.ReadLine() ?? string.Empty;
                    continue;

                }

            }
        }

    }
}