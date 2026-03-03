using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NBA_VIEW;
using E_APP.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NFL_VIEW;



namespace E_APP.VIEW.SPORTS_VIEW.SPORTS_MAIN_VIEW
{
    internal class Sports_Main_View
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Sports_Main_View()
        {
            load_Sports_Main_View();
        }
        private void load_Sports_Main_View()
        {

            data01[0] = $"1.) NBA\n" +
                        $"2.) NFL\n" +
                        $"3.) go back\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                if (Security_Serv01.empty_string(data01[1]) == false || Security_Serv01.string_only_digit(data01[1]) == false)
                {
                    data01[2] = "Invalid input. Please try again.";
                    Console.WriteLine(data01[2]);
                }
                if (Security_Serv01.empty_string(data01[1]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                new Sports_Selection_View01();
                                break;
                            case 2:
                                new Sports_Selection_Nfl_View01();
                                break;
                            case 3:
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