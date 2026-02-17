using E_APP.SERVICES.LANGUAGE_SERVICES;
using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.SECURITY_SERVICES;
namespace E_APP.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services01 Language_Serv01 = new Language_Services01();
        private bool keepsearching = true;
        public Translate_Selection_View01()
        {
            load_Translate_Selection_View01().Wait();
        }
        private async Task load_Translate_Selection_View01()
        {

            data01[0] = $"1.) Translate Text\n" +
                        $"2.) Translate Text with AI\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            foreach (var a in Language_Serv01.language)
                            {
                                data01[2] += $"{a}\n";
                            }
                            data01[3] = $"{Language_Serv01.data_array01[1]}\n" +
                                $"--------------------------------------------\n" +
                                $"{data01[2]}";
                            Console.WriteLine(data01[3]);
                            data01[4] = Console.ReadLine() ?? string.Empty;
                            while (keepsearching)
                            {
                                if (Security_Serv01.empty_string(data01[4]) == true)
                                {
                          
                                        if (data01[3] == "99")
                                        {
                                            keepsearching = false;
                                            data01[3] = string.Empty;
                                            break;
                                        }
                                        else
                                        {

                                            data01[5] = $"{Language_Serv01.data_array01[0]}";
                                            Console.WriteLine(data01[5]);
                                            data01[6] = Console.ReadLine() ?? string.Empty;
                                            while (keepsearching)
                                            {

                                                if (data01[6] == "99")
                                                {
                                                    keepsearching = false;
                                                    data01[3] = string.Empty;
                                                    break;
                                                }
                                                else
                                                {
                                                    if (Security_Serv01.empty_string(data01[6]) == true)
                                                    {
                                                        //  data01[7] = $"{Language_Serv01.code[int.Parse(data01[4])]}\n" +
                                                        //            $"{data01[6]}";
                                                        data01[7] = await Language_Serv01.Tranlate_Text(Language_Serv01.code[int.Parse(data01[4])], data01[6]);
                                                        Console.WriteLine(data01[7]);
                                                        keepsearching = true;
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        data01[7] = "Input cannot be empty. Please try again.";
                                                        Console.WriteLine(data01[7]);
                                                        keepsearching = true;
                                                        continue;
                                                    }
                                                }


                                            }
                                        }
                                    }
                                    else
                                    {
                                        data01[4] = "Input must be only digits. Please try again.";
                                        Console.WriteLine(data01[4]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
                                        keepsearching = true;
                                        continue;
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    keepsearching = true;
                                    continue;
                                }
                            }

                            break;
                        case 2:

                            foreach (var a in Language_Serv01.language)
                            {
                                data01[2] += $"{a}\n";
                            }
                            data01[3] = $"{Language_Serv01.data_array01[1]}\n" +
                                $"--------------------------------------------\n" +
                                $"{data01[2]}";
                            Console.WriteLine(data01[3]);
                            data01[4] = Console.ReadLine() ?? string.Empty;
                            while (keepsearching)
                            {
                                if (Security_Serv01.empty_string(data01[4]) == true)
                                {

                                    if (data01[4] == "99")
                                    {
                                        keepsearching = false;
                                        data01[3] = string.Empty;
                                        break;
                                    }
                                    else
                                    {

                                        data01[5] = $"{Language_Serv01.data_array01[0]}";
                                        Console.WriteLine(data01[5]);
                                        data01[6] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[6]) == true)
                                        {
                                            //  data01[7] = $"{Language_Serv01.code[int.Parse(data01[4])]}\n" +
                                            //            $"{data01[6]}";


                                            data01[7] = await Language_Serv01.Translate_using_Ai(Language_Serv01.code[int.Parse(data01[4])], data01[6]);
                                            Console.WriteLine(data01[7]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                        else
                                        {
                                            data01[7] = "Input cannot be empty. Please try again.";
                                            Console.WriteLine(data01[7]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }

                                }
                                else
                                {
                                    data01[4] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    keepsearching = true;
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