using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;

namespace E_APP.VIEW.TEST_VIEW.TEST_MAIN_VIEW
{
    internal class Test_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        public Test_Main_View01()
        {
            load_test_view();
        }
        private void load_test_view()
        {

            data01[0] = $"1.) files 01\n" +
                        $"2.) text files\n" +
                        $"3.) movies files\n" +
                        $"4.) random data\n" +
                        $"5.) random encryption\n" +
                        $"6.) pdf files" +
                        $"7.) go back\n";

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
                                new Test_Selection01();
                                break;
                            case 2:
                                new Test_Selection02();
                                break;
                            case 3:
                                new Test_Selection03();
                                break;
                            case 4:
                                new Test_Selection04();
                                break;
                            case 5:
                                new Test_Selection05();
                                break;
                            case 6:
                                return;
                        }
                    }
                    else
                    {
                        data01[0] = "Input must be only digits. Please try again.";
                        Console.WriteLine(data01[1]);
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;

                    }
                }
                else
                {
                    data01[0] = "Input must be only digits. Please try again.";
                    Console.WriteLine(data01[1]);
                    data01[1] = Console.ReadLine() ?? string.Empty;
                    continue;

                }
            }

        }
          
    }
}