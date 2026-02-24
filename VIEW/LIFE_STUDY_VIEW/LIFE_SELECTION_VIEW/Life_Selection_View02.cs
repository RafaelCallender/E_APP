using System;
using System.Threading.Tasks;
using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.AUDIO_SERVICES;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
namespace E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Book_of_Enoch01 Book_of_E01 = new Book_of_Enoch01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text03 Ai_Text_To_T03 = new Ai_Text_To_Text03();
        private static File_Helper01 File_H01=new File_Helper01();
        private string menus01 = "1.) Read the Enoch\n" +
                    "2.) Audio book of the Enoch\n" +
                    "3.) Questions about the Enoch\n" +
                    "4.) Record thoughts\n" +
                    "5.) Back to Main Menu\n";
        public Life_Selection_View02()
        {
            // Invoke the async method and wait for completion.
            // Fix for CS0119: call the method (add parentheses) to obtain a Task before calling Wait().
            Load_Life_Selection_View02().Wait();  
        }

        private async Task Load_Life_Selection_View02()
        {
            data01[0] = menus01;
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
                                string text = Book_of_E01.read_full_enoch_text();
                                Console.WriteLine(text);
                                return;

                            case 2:
                                string audioText = Book_of_E01.read_full_enoch_text();
                                await Audio_Serv01.convert_text_to_voice01(audioText);
                                Console.WriteLine(audioText);
                                return;

                            case 3:
                                Console.WriteLine("What questions about the Book of Enoch do you have?");
                                data01[2] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[1]) == true)
                                {

                                    string results = await Ai_Text_To_T03.text_to_text_content01(data01[2], Book_of_E01.LoadEnochChunks);
                                    string resualts01 = File_H01.file_saved(data01[2], results, 0);
                                    Console.WriteLine(resualts01);
                                    return;
                                }
                                else
                                {


                                    Console.WriteLine("Input cannot be empty. Please try again.\n");
                                    data01[2] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 4:
                                Console.WriteLine("Record your thoughts:");
                                data01[2] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[1]) == true)
                                {
                                    Console.WriteLine("NOT YET DEVELOPED.\n");
                                    return;

                                }
                                else
                                {

                                    Console.WriteLine("Input cannot be empty. Please try again.\n");
                                    continue;
                                }
           

                            case 5:
                                new Life_Main_View01();
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
