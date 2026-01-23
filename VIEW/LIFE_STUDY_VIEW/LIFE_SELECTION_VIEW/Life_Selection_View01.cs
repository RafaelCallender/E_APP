using E_APP.SERVICES.AUDIO_SERVICES;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SECURITY_SERVICES;

namespace E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01=new Ai_Text_To_Text01();
        public Life_Selection_View01()
        {
            load_Life_Selection_View01().Wait();
        }
        private async Task load_Life_Selection_View01()
        {

            data01[0] = $"1.) Read the Bible\n" +
                        $"2.) audio book of the Bible\n" +
                        $"3.) questions about the Bible\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {

                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            data01[2] += $"{The_Bible_Serv01.read_full_bible_text()}\n";
                            Console.WriteLine(data01[2]);
                            break;
                        case 2:
                            data01[2] = The_Bible_Serv01.read_full_bible_text();
                            await Audio_Serv01.text_to_voice01(data01[2]);
                            Console.WriteLine(data01[2]);
                            break;
                        case 3:
                            data01[2] = "what questions about he bible your have";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                data01[4] = await Ai_Text_To_T01.text_to_text_content01(data01[3], The_Bible_Serv01.LoadBibleChunks);
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
