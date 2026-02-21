using E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT;
using E_APP.SERVICES.IMAGE_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.FILE_PICKER;
namespace E_APP.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View01
    {
        private string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Image_Edit02 Image_E02 = new Image_Edit02();
        private static Image_Services01 Image_Serv01 = new Image_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private bool keepsearching = true;
        private static File_Picker01 File_P01= new File_Picker01();             

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


            data01[2] = $"Upload Photo\n" +
                        $"99 to go back\n";
            Console.WriteLine(data01[2]);
            data01[3] = await Image_Serv01.image_to_url(
               (await File_H01.find_default_single_face_images03())[0].Trim());
            while (keepsearching)
            {
                if (Security_Serv01.empty_string(data01[3]) == true)
                {
                    if(File_H01.isphoto(data01[3]) ==true)
                    {
                        if (data01[3] != "99")
                        {
                            data01[4] = $"Pick hair style\n" +
          $"---------------------------\n" +
          $"{data01[0]}\n" +
          $"99 to go back\n";

                            Console.WriteLine(data01[4]);
                            data01[5] = Console.ReadLine() ?? "";
                            if (Security_Serv01.empty_string(data01[5]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[5]) == true)
                                {
                                    if (data01[5] != "99")
                                    {
                                        data01[7] = await Image_E02.Hairstyle_Changer_Pro(int.Parse(data01[5]), int.Parse(data01[6]), data01[3]);
                                        data01[8] = await Image_Serv01.image_url_to_file(data01[7].Trim());
                                        File.Move(data01[8], File_Helper01.save_files[0]);
                                        keepsearching = true;
                                        continue;
                                    }
                                    else
                                    {
                                        keepsearching = false;
                                        return;
                                    }



                                }
                                else
                                {
                                    keepsearching = true;
                                    data01[3] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[3]);
                                    continue;
                                }
                            }
                            else
                            {
                                keepsearching = true;
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                                continue;
                            }
                        }
                        else
                        {
                            keepsearching = false;
                            return;

                        }

                    }
                    else
                    {
                        keepsearching = true;
                        data01[3] = "Input needs to be a photo. Please try again.";
                        Console.WriteLine(data01[3]);
                        data01[3] = File_P01.Filepicker_photo01();
                        continue;
                    }
                  
    
                }
                else
                {
                    keepsearching = true;
                    data01[3] = "Input cannot be empty. Please try again.";
                    Console.WriteLine(data01[3]);
                    data01[3] = File_P01.Filepicker_photo01();
                    continue;
                }



            }

        }
    }
}
      