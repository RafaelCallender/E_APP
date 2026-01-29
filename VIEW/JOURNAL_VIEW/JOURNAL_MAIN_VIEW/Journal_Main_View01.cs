using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.JOURNAL_VIEW.JOURNAL_SELECTION_VIEW;

namespace E_APP.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW
{
    internal class Journal_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Journal_Main_View01()
        {
            load_Journal_Main_View01();
        }
        private void load_Journal_Main_View01()
        {

            data01[0] = $"1.)Write Journal\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                            new Journal_Selection_View01();
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