using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.AI_VIEW.AI_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_IMAGE;
namespace E_APP.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Ai_Text_To_Image01 Ai_Text_To_I01= new Ai_Text_To_Image01();     
        private static File_Helper01 File_H01 = new File_Helper01();
        public Ai_Selection_View04()
        {
            load_Ai_Selection_View04().Wait();
        }
        private async Task load_Ai_Selection_View04()
        {

            data01[0] =
                        $"1.) Ai iamge gemeration \n" +
                        $"2.) to go back\n";
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
                                data01[2] = "What image would you like for me to make?";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {

                                    data01[4] = await Ai_Text_To_I01.AI_Text_to_image_Generator_Flux_Free(data01[3]);

                                //    string resualts01 = File_H01.file_saved(data01[3], data01[4], 1);
                                    Console.WriteLine(data01[4]);
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
                                new Ai_Main_View01();
                                return;

                        }
                        break;

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