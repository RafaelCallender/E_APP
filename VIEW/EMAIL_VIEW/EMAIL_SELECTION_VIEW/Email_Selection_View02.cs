using E_APP.SERVICES.EMAIL_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;


namespace E_APP.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Email_Services01 Email_Serv01 = new Email_Services01();
        public Email_Selection_View02()
        {
            load_Email_View01();
        }
        private void load_Email_View01()
        {

            data01[0] = $"semd email";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                            data01[2] = Email_Serv01.SendEmail();
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