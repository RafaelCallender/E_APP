using E_APP.MODEL.TEST_MODEL.TEST_GET_MODEL;
using E_APP.SERVICES.SECURITY_SERVICES;


namespace E_APP.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Test_Get_Model01 Test_Get_M01 =new Test_Get_Model01();    
        public Test_Selection04()
        {
            load_Test_Selection04();
        }
        private void load_Test_Selection04()
        {

            data01[0] = $"1.) output random data\n";


            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();

            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:


                            data01[2] = $"first_name: {Test_Get_M01.random_first_name}\n" +
                                $"last_name: {Test_Get_M01.random_last_name}\n" +
                                $"email_addresses: {Test_Get_M01.random_email_addresses}\n" +
                                $"phone_numbers: {Test_Get_M01.random_phone_numbers}\n" +
                                $"birthdays: {Test_Get_M01.random_birthdays}\n" +
                                $"username: {Test_Get_M01.random_username}\n"+
                                $"passwords: {Test_Get_M01.random_passwords}\n";
                            Console.WriteLine(data01[2]);


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

