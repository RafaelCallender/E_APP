using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.AUDIO_SERVICES;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using E_APP.SERVICES.SECURITY_SERVICES;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        private static Ai_Text_To_Text04 Ai_Text_To_T04 = new Ai_Text_To_Text04();
        private static Ai_Text_To_Text05 Ai_Text_To_T05 = new Ai_Text_To_Text05();
        private static Book_of_Enoch01 Book_of_E01 = new Book_of_Enoch01();
        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private bool keepsearching = true;
        public Life_Selection_View04()
        {
            load_Life_Selection_View01().Wait();
        }

        private async Task load_Life_Selection_View01()
        {

            data01[0] = $"1. ask questions about any of the books \n";
                  
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {

                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            data01[2] = "what questions do you have";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            while (keepsearching)
                            {
                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    if (data01[3] == "pp")
                                    {
                                        keepsearching = false;
                                        data01[4] = string.Empty;
                                        break;
                                    }
                                    else
                                    {
                                        Action[] chunkLoader = new Action[]
                                        {
                                            The_Book_Of_Jubilee.LoadBookChunks,
                                            The_Bible_Serv01.LoadBibleChunks,
                                            Book_of_E01.LoadEnochChunks
                                        };

                                        string resualts = await Ai_Text_To_T05.text_to_text_content01(data01[3], chunkLoader);
                                        Console.WriteLine(resualts);
                                        keepsearching = true;
                                        data01[3] = Console.ReadLine() ?? string.Empty;

                                        continue;
                                    }

                                }
                                else
                                {

                                    data01[4] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    keepsearching = true;
                                    data01[4] = string.Empty;
                                    data01[3] = Console.ReadLine() ?? string.Empty;

                                    continue;

                                }

                            }


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
