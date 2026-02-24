using E_APP.SERVICES.DEVICE_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.FILE_SERVICES.FILE_PICKER;
using E_APP.SERVICES.IMAGE_SERVICES;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.VIEW.AI_VIEW.AI_MAIN_VIEW;
using E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT;
namespace E_APP.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View01
    {
        private string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Image_Edit02 Image_E02 = new Image_Edit02();
        private static Image_Services01 Image_Serv01 = new Image_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Picker01 File_P01= new File_Picker01();
        private static Device_Services01 Device_Serv01 = new Device_Services01();
        public Ai_Selection_View01()
        {
            load_Ai_Selection_View01().Wait();
        }
        private async Task load_Ai_Selection_View01()
        {
            foreach (var a in Image_E02.hairstyle_data02)
            {
                data01[0] += $"{a}\n";

            }
            foreach (var a in Image_E02.hairstyle_data03)
            {
                data01[1] += $"{a}\n";

            }


            data01[2] = $"1.) Upload Photo\n" +
                          $"2.) to go back\n";
            Console.WriteLine(data01[2]);
            data01[3] = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                if (Security_Serv01.empty_string(data01[3]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[3]) == true)
                    {

                        switch (int.Parse(data01[3]))
                        {
                            case 1:
                                data01[4] = File_P01.Filepicker_photo01();
                                if (File_H01.isphoto(data01[4]) == true)
                                {

                                    Console.WriteLine(data01[0]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {
                                            Console.WriteLine(data01[1]);
                                            data01[6] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[6]) == true)
                                            {
                                                if (Security_Serv01.string_only_digit(data01[6]) == true)
                                                {
                                                    //data01[6] = await Image_Serv01.image_to_url(data01[5]);
                                                    // data01[7] = await Image_E02.Hairstyle_Changer_Pro(int.Parse(data01[5]), int.Parse(data01[6]),data01[4]);
                                                    //  data01[8] = Device_Serv01.launch_default_browser(data01[8]);
                                                    Console.WriteLine($"{Image_E02.hairstyle_data02[int.Parse(data01[5])]}\n," +
                                                                      $"{Image_E02.hairstyle_data03[int.Parse(data01[6])]}\n" +
                                                                      $"{data01[4]}\n");
                                             //       Console.WriteLine(data01[7]);
                                                    return; //needs work
                                                }
                                                else
                                                {
                                                    data01[22] = "Input needs to be a number. Please try again.";
                                                    Console.WriteLine(data01[22]);
                                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                                data01[22] = "Input cannot be empty. Please try again.";
                                                Console.WriteLine(data01[22]);
                                                data01[6] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }


                                        }
                                        else
                                        {
                                            data01[22] = "Input needs to be a number. Please try again.";
                                            Console.WriteLine(data01[1]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        data01[22] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[22]);
                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }


                                }
                                else
                                {
                                    data01[22] = "Input needs to be a photo. Please try again.";
                                    Console.WriteLine(data01[22]);
                                    data01[4] = File_P01.Filepicker_photo01();
                                    continue;
                                }
                            case 2:
                                new Ai_Main_View01();
                                return;

                        }


                    }
                    else
                    {
                        data01[22] = "Input cannot be empty. Please try again.";
                        Console.WriteLine(data01[22]);
                        data01[3] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {
                    data01[22] = "Input cannot be empty. Please try again.";
                    Console.WriteLine(data01[22]);
                    data01[3] = Console.ReadLine() ?? string.Empty;
                    continue;
                }

            }
        }
    }
}
