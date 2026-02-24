using E_APP.MODEL.USER_MODEL.TEST_MODEL.TEST_GET_MODEL;
using E_APP.SERVICES.CALENDAR_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES;


namespace E_APP.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Email_Services01 Sql_Email_Serv01 = new Sql_Email_Services01();
        private static Test_Get_Model01 Test_Get_M01 = new Test_Get_Model01();
        private static Calendar_Services01 Calendar_Serv01 = new Calendar_Services01();

        public Email_Selection_View01()
        {
            load_Email_View01();
        }
        private void load_Email_View01()
        {

            data01[0] = $"insert_email\n" +
                $"find_email_using_email\n" +
                $"find_email_using_name\n" +
                $"find_email_using_phonenumber\n" +
                $"find_full_name_using_email\n" +
                $"find_full_name_using_full_name\n" +
                $"find_full_name_using_phonenumber\n" +
                $"find_phonenumber_using_email\n" +
                $"find_phonenumber_using_fullname\n" +
                $"find_phonenumber_using_phonenumber\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                            string output = "";
                            data01[2] = "first Name";
                            Console.WriteLine(data01[2]);
                            data01[3] = Test_Get_M01.random_first_name;
                            data01[4] = "last Name";
                            data01[5] = Test_Get_M01.random_last_name;
                            Console.WriteLine(data01[4]);
                            string fullname = $"{data01[3]} {data01[5]}";
                            data01[6] = "email";
                            Console.WriteLine(data01[6]);
                            data01[7] = Test_Get_M01.random_email_addresses;
                            data01[8] = "Creation date";
                            Console.WriteLine(data01[8]);
                            data01[9] = Calendar_Serv01.calenderdateNow_array[8];
                            data01[10] = "phone_number";
                            Console.WriteLine(data01[10]);
                            data01[11] = Test_Get_M01.random_phone_numbers;
                            bool resaults = Sql_Email_Serv01.insert_email(fullname, data01[7], data01[9], data01[11], out output);
                            if (resaults)
                            {
                                data01[12] = output;
                            }
                            else
                            {
                                data01[12] = output;
                            }
                                Console.WriteLine(data01[12]);
                            break;

                            
                    }
                }
                else
                {
                    data01[2] = "Input must be only digits. Please try again.";
                    Console.WriteLine(data01[2]);

                }
            }
            else
            {
                data01[2] = "Input cannot be empty. Please try again.";
                Console.WriteLine(data01[2]);

            }


        }

    }
}