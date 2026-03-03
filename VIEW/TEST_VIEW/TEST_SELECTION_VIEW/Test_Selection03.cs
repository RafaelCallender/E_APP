using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.TEST_VIEW.TEST_MAIN_VIEW;


namespace E_APP.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        public Test_Selection03()
        {
            load_Test_Selection03();
        }
        private void load_Test_Selection03()
        {

            data01[0] = $"1.) find_Movie_files01\n" +
                         $"2.) go back\n";


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


                                data01[2] = File_H01.find_Movie_files01();
                                Console.WriteLine(data01[2]);


                                return;
                            case 2:
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
