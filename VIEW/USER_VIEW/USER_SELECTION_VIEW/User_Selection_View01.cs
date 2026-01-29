using E_APP.SERVICES.SECURITY_SERVICES;


namespace E_APP.VIEW.USER_VIEW.USER_SELECTION_VIEW
{
    internal class User_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public User_Selection_View01()
        {
            load_User_Selection_View01();
        }
        private void load_User_Selection_View01()
        {

            data01[0] = $"1.) Login \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                         
                            break;
                        case 2:
                          
                            break;
                        case 3:
                        
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