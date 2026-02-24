using E_APP.MODEL.USER_MODEL.TEST_MODEL.TEST_GET_MODEL;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;
using E_APP.VIEW.USER_VIEW.USER_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.Win32.NativeMethods;

namespace E_APP.VIEW.USER_VIEW.USER_SELECTION_VIEW
{
    internal class User_Selection_View05
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        private static Test_Get_Model01 Test_Get_M01 = new Test_Get_Model01();



        public User_Selection_View05()
        {
            load_User_Selection_View05();
        }
        private void load_User_Selection_View05()
        {

            data01[0] = $"1.) create user \n" +
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
                                string resaults = string.Empty;
                                for (int i = 0; i < 100; i++)
                                {
                                    data01[3] = "username";
                                    Console.WriteLine(data01[3]);
                                    data01[4] = Test_Get_M01.random_username;

                                    data01[5] = "firstname";
                                    Console.WriteLine(data01[5]);
                                    data01[6] = Test_Get_M01.random_first_name;

                                    data01[7] = "lastname";
                                    Console.WriteLine(data01[7]);
                                    data01[8] = Test_Get_M01.random_last_name;

                                    data01[9] = "birthday";
                                    Console.WriteLine(data01[9]);
                                    data01[10] = Test_Get_M01.random_birthdays;

                                    data01[11] = "email";
                                    Console.WriteLine(data01[11]);
                                    data01[12] = Test_Get_M01.random_email_addresses;

                                    data01[13] = "phonenumber";
                                    Console.WriteLine(data01[13]);
                                    data01[14] = Test_Get_M01.random_phone_numbers;

                                    data01[15] = "password";
                                    Console.WriteLine(data01[15]);
                                    data01[16] = Test_Get_M01.random_passwords;

                         

                                }
                                if (Sql_Serv01.insert_user(data01[4],
                                                                                                  data01[6],
                                                                                                  data01[8],
                                                                                                  data01[10],
                                                                                                  data01[12],
                                                                                                  data01[14],
                                                                                                  data01[16], out resaults) == true)
                                {
                                    data01[17] += resaults;
                                    Console.WriteLine(data01[17]);
                                    break;
                                }
                                else
                                {
                                    data01[17] += resaults;
                                    Console.WriteLine(data01[17]);
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