using System;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW;


namespace E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW
{
    internal class Life_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Life_Main_View01()
        {
            load_Life_Main_View01();
        }
        private void load_Life_Main_View01()
        {

            data01[0] = $"1.) The Bible\n" +
                        $"2.) The Book of Enoch.\n" +
                        $"3.) The Book of Jubilees\n" +
                        $"4.)all Books";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                            new Life_Selection_View01();
                            break;
                        case 2:
                            new Life_Selection_View02();
                            break;
                        case 3:

                            if (OperatingSystem.IsWindows())
                            {
                                var view = new Life_Selection_View03();
        
                            }
                            else
                            {
                                data01[2] = "Option 3 (The Book of Jubilees) is only supported on Windows.";
                                Console.WriteLine(data01[2]);
                            }
                            break;
                        case 4:
                            new Life_Selection_View04();
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