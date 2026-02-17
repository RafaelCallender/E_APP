using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.AUDIO_SERVICES;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using E_APP.SERVICES.SECURITY_SERVICES;
using System.Runtime.Versioning;

namespace E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    [SupportedOSPlatform("windows")]
    internal class Life_Selection_View03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        private static Ai_Text_To_Text04 Ai_Text_To_T04 = new Ai_Text_To_Text04();
        private bool keepsearching = true;
        public Life_Selection_View03()
        {
            load_Life_Selection_View01().Wait();
        }

        private async Task load_Life_Selection_View01()
        {

            data01[0] = $"1.) Read the Jubilees\n" +
                        $"2.) audio book of the Jubilees\n" +
                        $"3.) questions about the Jubilees\n"+
                        $"4.) record thoughts\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {

                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            data01[2] =The_Book_Of_Jubilee.read_full_book_text();
                            Console.WriteLine(data01[2]);

                            break;
                        case 2:
                            data01[2] += $"{The_Book_Of_Jubilee.read_full_book_text()}\n";
                            await Audio_Serv01.convert_text_to_voice01(data01[2]);
                            Console.WriteLine(data01[2]);
                            break;
                        case 3:

                            data01[2] = "what questions about the book of jubiless your have";
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

                                        string resualts = await Ai_Text_To_T04.text_to_text_content01(data01[3], The_Book_Of_Jubilee.LoadBookChunks);
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
                        case 4:
                            data01[2] = "Record Thoughts";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {


                                Console.WriteLine(data01[4]);
                            }
                            else
                            {
                                data01[4] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[4]);
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
