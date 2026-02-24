using E_APP.SERVICES.NEWS_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.NEWS_VIEW.NEWS_MAIN;


namespace E_APP.VIEW.NEWS_VIEW.NEWS_SELECTION_VIEW
{
    internal class News_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static News_Services01 News_Serv01 = new News_Services01();
        private bool keepsearching = true;
        public News_Selection_View01()
        {
            load_News_Selection_View01().Wait();
        }
        private async Task load_News_Selection_View01()
        {

            data01[0] =
                        $"1.) Real_Time_News_Data_GET_Search\n" +
                        $"2.)Real_Time_News_Data_GET_Top_Headlines\n" +
                        $"3.)Real_Time_News_Data_GET_Topic_Headlines\n" +
                        $"4.)Real_Time_News_Data_GET_Topic_News_By_Section\n" +
                        $"5.)Local_Headlines_Geo\n" +
                        $"6.)Full_Story_Coverage\n" +
                        $"7.)Real_Time_News_Data_GET_Language_List\n" +
                        $"8.) go back\n";
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

                                data01[2] = $"{News_Serv01.data_array[1]}";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    data01[4] = await News_Serv01.Real_Time_News_Data_GET_Search(data01[3]);
                                    Console.WriteLine(data01[4]);
        
                                    return;
                                }
                                else
                                {
                                    data01[4] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }




                            case 2:


                                data01[4] = await News_Serv01.Real_Time_News_Data_GET_Top_Headlines();
                                Console.WriteLine(data01[4]);
                                return;
                            case 3:


                                data01[4] = await News_Serv01.Real_Time_News_Data_GET_Topic_Headlines();
                                Console.WriteLine(data01[4]);
                                return;
                            case 4:

                                data01[2] = $"{News_Serv01.data_array[0]}";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    data01[4] = await News_Serv01.Real_Time_News_Data_GET_Topic_News_By_Section(data01[3]);
                                    Console.WriteLine(data01[4]);
                                    return;
                                }
                                else
                                {
                                    data01[4] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 5:

                                data01[2] = $"{News_Serv01.data_array[0]}";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3]) == true)
                                {
                                    data01[4] = await News_Serv01.Local_Headlines_Geo(data01[3]);
                                    Console.WriteLine(data01[4]);
                                    return;
                                }
                                else
                                {
                                    data01[4] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }


                            case 6:

                                data01[4] = await News_Serv01.Full_Story_Coverage();
                                Console.WriteLine(data01[4]);
                                return;
                            case 7:

                                data01[4] = await News_Serv01.Real_Time_News_Data_GET_Language_List();
                                Console.WriteLine(data01[4]);
                                return;
                            case 8:
                                new News_Main_View01();             
                                return;
                        }
                    }
                    else
                    {
                        data01[2] = "Input must be only digits. Please try again.";
                        Console.WriteLine(data01[2]);
                        data01[3] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {
                    data01[2] = "Input cannot be empty. Please try again.";
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine() ?? string.Empty;
                    continue;
                }
            }
        }
    }
}