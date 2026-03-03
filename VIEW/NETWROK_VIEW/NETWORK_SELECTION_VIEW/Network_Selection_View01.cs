using E_APP.SERVICES.NETWORK_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.VIEW.NETWROK_VIEW.NETWORK_SELECTION_VIEW
{
    internal class Network_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Network_Services01 Network_S01 = new Network_Services01();
        public Network_Selection_View01()
        {
            load_Network_Selection_View01();
        }
        private void load_Network_Selection_View01()
        {

            data01[0] = $"1.) scan network\n" +
                        $"2.) network monitor\n" +
                        $"3.) network_monitor01\n" +
                        $"4.) go back\n";
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

                                data01[2] = Network_S01.scan_netwrok();
                                Console.WriteLine(data01[2]);
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;
                            case 2:

                                data01[2] = Network_S01.network_monitor();
                                Console.WriteLine(data01[2]);
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;
                            case 3:

                                data01[2] = Network_S01.network_monitor01();
                                Console.WriteLine(data01[2]);
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;
                            case 4:
                                return;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Input must be only digits. Please try again.");
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    data01[1] = Console.ReadLine() ?? string.Empty;
                    continue;

                }


            }

        }


    }
}