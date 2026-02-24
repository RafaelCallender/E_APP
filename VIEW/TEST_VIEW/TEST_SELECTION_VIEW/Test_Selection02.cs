using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;
using E_APP.SERVICES.LANGUAGE_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
namespace E_APP.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static Language_Services01 Language_Serv01 = new Language_Services01();
      
        public Test_Selection02()
        {
            load_Test_Selection02();
        }
        private void load_Test_Selection02()
        {

            data01[0] = $"1.) The_Bible01\n" +
                $"2.) api\n" +
                $"3.) elements\n" +
                $"4.) language_abbreviation\n" +
                $"5.) language name 01\n" +
                $"6.) CloudinaryDotNet_info\n" +
                $"7.) hairstyle_info_01\n" +
                $"8.) hairstyle_info_02\n" +
                $"9.) The_Book_of_Enoch\n" +
                $"10.) elements_category\n" +
                $"11.) language name 02\n" +
                $"12.) encrypt files" +
                $"13.) go back";

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

                                data01[2] += $"{Read_T01.The_Bible_KJV}\n";

                                Console.WriteLine(data01[2]);


                                return;



                            case 2:

                                foreach (var a in Read_T01.API)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 3:

                                foreach (var a in Read_T01.Chemistry)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 4:

                                foreach (var a in Read_T01.Language_Abbreviation)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 5:

                                foreach (var a in Read_T01.Language_Name)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 6:

                                foreach (var a in Read_T01.cloudinary_com)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 7:

                                foreach (var a in Read_T01.hairstyle_info_01)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 8:

                                foreach (var a in Read_T01.hairstyle_info_02)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 9:

                                foreach (var a in Read_T01.The_Book_of_Enoch)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
                                return;

                            case 10:
                                foreach (var a in Read_T01.Chemistry01)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);

                                return;
                            case 11:

                                data01[2] += $"{Language_Serv01.test()}\n";

                                Console.WriteLine(data01[2]);

                                return;

                                case 12:
                                data01[2] = $"{Security_Serv01.encrypt_text_file(Read_T01.admin_path01)}\n" +
                                            $"{Security_Serv01.decrypt_text_file(Read_T01.admin_path01)}\n";
                            
                                Console.WriteLine(data01[2]);

                            
                                return;
                            case 13:
                                new Test_Main_View01();
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

