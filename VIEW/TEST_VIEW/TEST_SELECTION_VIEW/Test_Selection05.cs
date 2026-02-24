using E_APP.MODEL.USER_MODEL.TEST_MODEL.TEST_GET_MODEL;
using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.USER_VIEW.USER_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection05
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Test_Get_Model01 Test_Get_M01 = new Test_Get_Model01();
        private static Read_Textfiles Read_T01 = new Read_Textfiles();  
        public Test_Selection05()
        {
            load_Test_Selection05();
        }
        private void load_Test_Selection05()
        {

            data01[0] = $"1.) ADMIN encryption\n" +
                        $"2.) ADMIN encryption 02\n" +
                        $"2) go back\n";


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

                                string org = $"{Read_T01.admin_path01.Trim()}\n";
                                string enc = $"{Security_Serv01.encrypt_text_file(Read_T01.admin_path01.Trim())}\n";
                                string sorc = $"{Security_Serv01.decrypt_text_file(enc)}\n";



                                data01[2] = $"{org}\n" +
                                            $"{enc}\n" +
                                            $"{sorc}\n";
                                Console.WriteLine(data01[2]);

                                return;

                            case 2:

                                string org01 = $"{Read_T01.admin_path01.Trim()}\n";
                                string enc01 = $"{Security_Serv01.Shift_XOR_Position_Encryption(Read_T01.admin_path01.Trim())}\n";
                                string sorc01 = $"{Security_Serv01.Shift_XOR_Position_Decryption(enc01)}\n";



                                data01[2] = $"{org01}\n" +
                                            $"{enc01}\n" +
                                            $"{sorc01}\n";
                                Console.WriteLine(data01[2]);

                                return;


                            case 3:
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

