using E_APP.SECURITY_SERVICES;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    internal class Science_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Science_Selection_View02()
        {
            load_Science_Selection_View02();
        }
        private void load_Science_Selection_View02()
        {

            data01[0] = 
                        $"1.) Nasa";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:
                  
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Input must be only digits. Please try again.");
                    data01[1] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                data01[1] = Console.ReadLine();

            }


        }

    }
}