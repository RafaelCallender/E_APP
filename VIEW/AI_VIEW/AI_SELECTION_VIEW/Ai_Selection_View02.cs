using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.SECURITY_SERVICES;


namespace E_APP.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        public Ai_Selection_View02()
        {
            load_Ai_Selection_View02().Wait();
        }
        private async Task load_Ai_Selection_View02()
        {

            data01[0] =
                        $"1.) Ai text gemeration \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                            data01[2] = "Tell me whats on your mind";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                data01[4] = await Ai_Text_To_T01.text_to_text_generator01(data01[3]);
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
