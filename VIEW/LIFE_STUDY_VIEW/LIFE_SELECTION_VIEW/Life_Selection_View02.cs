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
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Book_of_Enoch01 Book_of_E01 = new Book_of_Enoch01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text03 Ai_Text_To_T03 = new Ai_Text_To_Text03();
        private static File_Helper01 File_H01=new File_Helper01();  
        public Life_Selection_View02()
        {
            _ = LoadLifeSelectionViewAsync();
        }

        private async Task LoadLifeSelectionViewAsync()
        {
            while (true)
            {
                Console.WriteLine(
                    "1.) Read the Enoch\n" +
                    "2.) Audio book of the Enoch\n" +
                    "3.) Questions about the Enoch\n" +
                    "4.) Record thoughts\n" +
                    "5.) Back to Main Menu\n");

                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.\n");
                    continue;
                }

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Input must be only digits. Please try again.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        string text = Book_of_E01.read_full_enoch_text();
                        Console.WriteLine(text);
                        break;

                    case 2:
                        string audioText = Book_of_E01.read_full_enoch_text();
                        await Audio_Serv01.convert_text_to_voice01(audioText);
                        Console.WriteLine(audioText);
                        break;

                    case 3:
                        Console.WriteLine("What questions about the Book of Enoch do you have?");
                        string question = Console.ReadLine() ?? string.Empty;

                        if (Security_Serv01.empty_string(question))
                        {
                            Console.WriteLine("Input cannot be empty. Please try again.\n");
                            continue;
                        }
                        else
                        {
                           
                            string results =await Ai_Text_To_T03.text_to_text_content01(question, Book_of_E01.LoadEnochChunks);
                            string resualts01 = File_H01.file_saved(question, results, 0);

                            Console.WriteLine(resualts01);
                           
                             
                            
                            
                            continue;
                        }





                    case 4:
                        Console.WriteLine("Record your thoughts:");
                        string thoughts = Console.ReadLine() ?? string.Empty;

                        if (string.IsNullOrWhiteSpace(thoughts))
                        {
                            Console.WriteLine("Input cannot be empty. Please try again.\n");
                            continue;
                        }

                        Console.WriteLine("Thought recorded successfully.\n");
                        // TODO: Save thoughts to file or database
                        break;

                    case 5:
                        new Life_Main_View01();
                        return;

                    default:
                        Console.WriteLine("Invalid selection. Please choose 1–5.\n");
                        break;
                }
            }
        }
    }
}
