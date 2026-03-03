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
      //  private static Language_Services01 Language_Serv01 = new Language_Services01();
      
        public Test_Selection02()
        {
            load_Test_Selection02();
        }
        private void load_Test_Selection02()
        {

            data01[0] =
        $"1.) admin_path01\n" +
        $"2.)API\n" +
        $"3.) Chemistry\n" +
        $"4.) Chemistry01\n" +
        $"5.) Client_Textfile01\n" +
        $"6.) cloudinary_com\n" +
        $"7.) hairstyle_info_01\n" +
        $"8.) hairstyle_info_02\n" +
        $"9.) Language_Abbreviation\n" +
        $"10.) Language_Name\n" +
        $"11.) The_Book_of_Enoch\n" +
        $"12.) The_Book_of_Jubilees\n" +
        $"13.) The_Bible_KJV\n" +
        $"14.) back\n";

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

                                data01[2] += $"{Read_T01.admin_path01}\n";

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

                                foreach (var a in Read_T01.Chemistry01)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);


                                return;
                            case 5:


                                data01[2] += Read_T01.Client_Textfile01;
                                
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

                                foreach (var a in Read_T01.Language_Abbreviation)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
                                return;

                            case 10:
                                foreach (var a in Read_T01.Language_Name)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);

                                return;
                            case 11:
                              data01[2] = Read_T01.The_Book_of_Enoch;
                                Console.WriteLine(data01[2]);       
                                return;
                            case 12:
                                data01[2] = Read_T01.The_Book_of_Jubilees;
                                Console.WriteLine(data01[2]);
                                return;
                            case 13:
                                data01[2] = Read_T01.The_Bible_KJV;
                                Console.WriteLine(data01[2]);
                                return;
                            case 14:
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

