using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using E_APP.VIEW.AI_VIEW.AI_MAIN_VIEW;
using static E_APP.SERVICES.FILE_SERVICES.FILE_HELPER.File_Helper01;

namespace E_APP.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        private static File_Helper01 File_H01 = new File_Helper01();
        public Ai_Selection_View02()
        {
            load_Ai_Selection_View02().Wait();
        }
        private async Task load_Ai_Selection_View02()
        {

            data01[0] =
                        $"1.) Ai text gemeration \n" +
                        $"2.) Ai text gemeration for developers \n" +
                        $"3.) to go back\n";
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
                                string res01 = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.question);
                                data01[2] = "Tell me whats on your mind\n";
                                     
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                             
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                  

                                    data01[4] = await Ai_Text_To_T01.text_to_text_generator01(data01[3]);

                                    res01 = File_H01.file_saved(data01[3], data01[4], (int)File_Helper01.file_path_data01_enum.question);
                                        Console.WriteLine(res01);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                     


                                }
                                else
                                {

                                    Console.WriteLine("Input cannot be empty. Please try again.");
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 2:
                                data01[2] = "lets develop together. how can i help?";
                                string res = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.developers);
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                          
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                  
                                    data01[4] = await Ai_Text_To_T01.text_to_text_generator02(data01[3]);

                                         res = File_H01.file_saved(data01[3], data01[4], (int)File_Helper01.file_path_data01_enum.developers); 
                              
                                        Console.WriteLine(res);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                        

                                }
                                else
                                {

                                    Console.WriteLine("Input cannot be empty. Please try again.");
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                       

                            case 3:
                                new Ai_Main_View01();
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