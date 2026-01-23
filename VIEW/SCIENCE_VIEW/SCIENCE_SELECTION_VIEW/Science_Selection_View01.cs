using E_APP.SECURITY_SERVICES;
using E_APP.SERVICES.SCIENCE_SERVICES.CHEMISTORY_SERVICES;


namespace E_APP.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    internal class Science_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Chemistory_Services01 Chemistory_Serv01 = new Chemistory_Services01();
        private int count = 0;
        public Science_Selection_View01()
        {
            load_Science_Selection_View01().Wait();
        }
        private async Task load_Science_Selection_View01()
        {

            data01[0] = 
                     $"1.)find_element_using_textfile\n" +
                     $"2.)find_element_using_sql\n" +
                     $"3.) find_element_using_sqlite\n" +
                     $"4.)view_all_elements_using_textfile\n" +
                     $"5.) find_category_elements_using_sqlite\n" +
                     $"7.) find_category_elements_table\n" +
                     $"8.) view_all_elements_using_sqlit\n";




            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                            data01[2] = "Search Element";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                data01[4] = Chemistory_Serv01.find_element_using_textfile(data01[3]);
                                Console.WriteLine(data01[4]);
                            }
                            else
                            {
                                data01[4] = "Input must be only digits. Please try again.";
                                Console.WriteLine(data01[4]);
                            }

                            break;
                        case 2:
                            data01[2] = "Search Element";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                data01[4] = Chemistory_Serv01.find_element_using_sql(data01[3]);
                                Console.WriteLine(data01[4]);
                            }
                            else
                            {
                                data01[4] = "Input must be only digits. Please try again.";
                                Console.WriteLine(data01[4]);
                            }

                            break;
                        case 3:
                            data01[2] = "Search Element";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                data01[4] = await Chemistory_Serv01.find_element_using_sqlite(data01[3]);
                                Console.WriteLine(data01[4]);
                            }
                            else
                            {
                                data01[4] = "Input must be only digits. Please try again.";
                                Console.WriteLine(data01[4]);
                            }

                            break;
                        case 4:
                            data01[2] = Chemistory_Serv01.view_all_elements_using_textfile();
                            Console.WriteLine(data01[2]);
                            break;
                        case 5:
                            count = 0;
                            foreach (var a in Chemistory_Serv01.data_array)
                            {
                                count++;
                                data01[2] = $"{count}.) {a}\n";
                            }
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Chemistory_Serv01.find_category_elements_using_sqlite(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[4]);
                                }
                            }
                            else
                            {
                                data01[4] = "Input must be only digits. Please try again.";
                                Console.WriteLine(data01[4]);
                            }

                            break;
                        case 6:
                            count = 0;
                            foreach (var a in Chemistory_Serv01.data_array)
                            {
                                count++;
                                data01[2] = $"{count}.) {a}\n";
                            }
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Chemistory_Serv01.find_category_elements_using_sql(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[4]);
                                }
                            }
                            else
                            {
                                data01[4] = "Input must be only digits. Please try again.";
                                Console.WriteLine(data01[4]);
                            }


                            break;
                        case 7:
                            count = 0;
                            foreach (var a in Chemistory_Serv01.data_array)
                            {
                                count++;
                                data01[2] += $"{count}.) {a}\n";
                            }
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = Chemistory_Serv01.find_category_elements_table(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[4]);
                                }
                            }
                            else
                            {
                                data01[4] = "Input must be only digits. Please try again.";
                                Console.WriteLine(data01[4]);
                            }


                            break;
                        case 8:

                            data01[4] = await Chemistory_Serv01.view_all_elements_using_sqlit();
                            Console.WriteLine(data01[4]);


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