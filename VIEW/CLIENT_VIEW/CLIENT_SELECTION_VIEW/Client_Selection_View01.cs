using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES;
using E_APP.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.VIEW.CLIENT_VIEW.CLIENT_SELECTION_VIEW
{
    internal class Client_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        private string resaults = string.Empty;



        public Client_Selection_View01()
        {
            load_Client_Selection_View01();
        }
        private void load_Client_Selection_View01()
        {

            data01[0] = $"1.)sql client\n" +
                        $"2.) delete_client_using_email\n" +
                        $"3.) delete_client_using_name\n" +
                        $"3.) find_client_email_by_email\n" +
                        $"4.) find_client_email_by_name\n" +
                        $"5.) find_client_email_by_phonenumber\n" +
                        $"6.) find_client_name_by_email\n" +
                        $"7.) find_client_name_by_name \n" +
                        $"8.) find_client_name_by_phonenumber\n" +
                        $"0.) find_client_phonenumber_by_email\n" +
                        $"10.) find_client_phonenumber_by_name\n" +
                        $"11.) find_client_phonenumber_by_phonenumber\n" +
                        $"12.) insert_client\n" +
                        $"13.) update_clients_email_using_email\n" +
                        $"14.) update_clients_email_using_name\n" +
                        $"15.) update_clients_email_using_phonenumber\n" +
                        $"16.) update_clients_name_using_email\n" +
                        $"17.) update_clients_name_using_name\n" +
                        $"18.) update_clients_name_using_phonenumber\n" +
                        $"19.) update_clients_phonenumber_using_email\n" +
                        $"20.) update_clients_phonenumber_using_name\n" +
                        $"21.) update_clients_phonenumber_using_phonenumber\n" +
                        $"22.) go back\n";
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
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3]) == true)
                                    {

                                        if (Sql_Client_S01.delete_client_using_email(data01[3], out resaults) == true)
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;

                                        }
                                        else
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        data01[22] = "Input not correct formate. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 2:
                                data01[2] = $"clients name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    if (Sql_Client_S01.delete_client_using_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 3:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    if (Sql_Client_S01.find_client_email_by_email(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 4:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    if (Sql_Client_S01.find_client_email_by_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 5:
                                data01[2] = $"clients phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {

                                    if (Security_Serv01.phone_check(data01[3]) == true)
                                    {
                                        if (Sql_Client_S01.find_client_email_by_phonenumber(data01[3], out resaults) == true)
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;

                                        }
                                        else
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }

                                    }
                                    else
                                    {
                                        data01[22] = "Input not phone number formate. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }



                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 6:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {

                                    if (Security_Serv01.email_check(data01[3]) == true)
                                    {
                                        if (Sql_Client_S01.find_client_name_by_email(data01[3], out resaults) == true)
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;

                                        }
                                        else
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }

                                    }
                                    else
                                    {
                                        data01[22] = "Input not phone number formate. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }



                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 7:
                                data01[2] = $"clients name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.find_client_name_by_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 8:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {

                                    if (Security_Serv01.phone_check(data01[3])==true)
                                    {
                                        if (Sql_Client_S01.find_client_name_by_phonenumber(data01[3], out resaults) == true)
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;

                                        }
                                        else
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }

                                    }
                                    else
                                    {
                                        data01[22] = "Input must be only digits. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }
                                




                                }
                                else
                                {

                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 9:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {

                                    if (Security_Serv01.email_check(data01[3])==true)
                                    {
                                        if (Sql_Client_S01.find_client_phonenumber_by_email(data01[3], out resaults) == true)
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;

                                        }
                                        else
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }


                                    }
                                    else
                                    {
                                        data01[22] = "Input not correct for email. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }
              



                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 10:
                                data01[2] = $"clients name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.find_client_phonenumber_by_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 11:
                                data01[2] = $"clients phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3]) == true)
                                    {
                                        if (Sql_Client_S01.find_client_phonenumber_by_phonenumber(data01[3], out resaults) == true)
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;

                                        }
                                        else
                                        {
                                            data01[22] = resaults;
                                            Console.WriteLine(data01[22]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        data01[22] = "Input not correct formate for phonenumber. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                               





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 12:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    /*      if (Sql_Client_S01.insert_client(data01[3], out resaults) == true)
                                          {
                                              data01[22] = resaults;
                                              Console.WriteLine(data01[22]);
                                              data01[3] = Console.ReadLine() ?? string.Empty;
                                              return;

                                          }
                                          else
                                          {
                                              data01[22] = resaults;
                                              Console.WriteLine(data01[22]);
                                              data01[3] = Console.ReadLine() ?? string.Empty;
                                              continue;
                                          }*/
                                    return;

                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 13:

                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_email_using_email(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 14:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_email_using_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 15:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_email_using_phonenumber(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 16:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_name_using_email(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 17:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_name_using_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 18:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_name_using_phonenumber(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 19:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_phonenumber_using_email(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 20:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_phonenumber_using_name(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 21:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {


                                    if (Sql_Client_S01.update_clients_phonenumber_using_phonenumber(data01[3], out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        return;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }





                                }
                                else
                                {
                                    data01[22] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }


                            case 22:
                                new Client_View01();
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