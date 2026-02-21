using E_APP.SERVICES.LANGUAGE_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;

namespace E_APP.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{

    internal class Translate_Selection_View02
    {
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services01 Language_Serv01 = new Language_Services01();
        private bool keepsearching = true;
        public Translate_Selection_View02()
        {
            load_Translate_Selection_View02().Wait();
        }
        public async Task load_Translate_Selection_View02()
        {
            while (keepsearching)
            {
                Console.WriteLine("1.) Translate Text");
                Console.WriteLine("2.) Translate Text with AI");
                Console.WriteLine("99.) Back");

                string choice = Console.ReadLine() ?? string.Empty;

                if (Security_Serv01.empty_string(choice) == true)
                {
                    if(Security_Serv01.string_only_digit(choice)==true)
                    {
                        switch (choice)
                        {
                            case "1":
                                await HandleTranslate();
                                keepsearching = true;
                                continue;

                            case "2":
                                await HandleTranslate();
                                keepsearching = true;
                                continue;

                            case "99":
                                new Program();
                                keepsearching = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input must be only digits. Please try again.");
                        choice = Console.ReadLine() ?? string.Empty;
                        keepsearching=true;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    choice = Console.ReadLine() ?? string.Empty;
                    keepsearching=true;     
                    continue;
                }

               
            }
        }



        private async Task HandleTranslate()
        {
            ShowLanguages();

            string languageChoice = Console.ReadLine() ?? string.Empty;

            if (languageChoice == "99")
            {
                new Program();
            }
            else
            {

                Console.WriteLine(Language_Serv01.data_array01[0]);
                string text = Console.ReadLine() ?? string.Empty;

                if (text == "99")
                {
                    new Program();

                }
                else
                {

                    string languageCode = Language_Serv01.code[int.Parse(languageChoice)];

                    string result =
                      await Language_Serv01.Tranlate_Text(languageCode, text);
                    Console.WriteLine(result);
                    Console.WriteLine("\nPress Enter to continue or 99 to go back.");
                    string next = Console.ReadLine() ?? string.Empty;
                }
            }
    

        }

        private void ShowLanguages()
        {
            Console.WriteLine(Language_Serv01.data_array01[1]);
            Console.WriteLine("--------------------------------------------");

            foreach (var lang in Language_Serv01.language)
            {
                Console.WriteLine(lang); 
            }
       

            Console.WriteLine("99.) Back");
        }

      
    }
}
