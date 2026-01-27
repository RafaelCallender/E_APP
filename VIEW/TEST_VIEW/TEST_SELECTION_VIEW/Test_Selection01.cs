using E_APP.SECURITY_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
namespace E_APP.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        public Test_Selection01()
        {
            load_Test_Selection01();
        }
        private void load_Test_Selection01()
        {

            data01[0] = $"1.) File_H01.all_embedded_files\n" +
                        $"2.) File_H01.all_embedded_pdf\n" +
                        $"3.) File_H01.all_embedded_images\n" +
                        $"4.) File_H01.all_embedded_excel\n" +
                        $"5.) File_H01.all_embedded_gguf_models\n" +
                        $"6.) File_H01.all_embedded_python_files\n" +
                        $"7.) File_H01.find_python_exe\n" +
                        $"8.) File_H01.all_embedded_exe_files\n" +
                        $"9.) File_H01.find_all_files_in_project\n" +
                        $"10.) File_H01.find_default_single_face_images02\n" +
                        $"11.) File_H01.find_default_single_face_images03\n" +
                        $"12.) File_H01.find_default_group_face_images01\n" +
                        $"13.) File_H01.all_embedded_safetensors_models\n" +
                        $"14.) File_H01.all_text_to_text_gguf_models\n" +
                        $"15.) File_H01.all_text_to_image_gguf_models\n" +
                        $"16.) File_H01.all_text_to_image_safetensors_models\n" +
                        $"17.) File_H01.all_python_files\n" +
                        $"18.) all_text_to_text_gguf_models\n" +
                        $"19.) all_gguf_translate\n" +
                        $"20.) all_embedded_files01\n" +
                        $"21.) all_saved_audio\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();

            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            data01[2] = $"{File_H01.all_embedded_files()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 2:

                            data01[2] = $"{File_H01.all_embedded_pdf()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 3:

                            data01[2] = $"{File_H01.all_embedded_images()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 4:

                            data01[2] = $"{File_H01.all_embedded_excel()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 5:

                            data01[2] = $"{File_H01.all_embedded_gguf_models()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 6:

                            data01[2] = $"{File_H01.all_embedded_python_files()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 7:

                            data01[2] = $"{File_H01.find_python_exe()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 8:

                            data01[2] = $"{File_H01.all_embedded_exe_files()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 9:

                            data01[2] = $"{File_H01.find_all_files_in_project()}\n";
                            Console.WriteLine(data01[2]);


                            break;
                        case 10:
                            foreach(var a in  File_H01.find_default_single_face_images02() )
                            {
                                data01[2] += $"{a}\n"; 
                            }
                         
                            Console.WriteLine(data01[2]);


                            break;
                        case 11:
                            foreach (var a in File_H01.find_default_single_face_images03())
                            {
                                data01[2] += $"{a}\n";
                            }
                  
                            Console.WriteLine(data01[2]);


                            break;
                        case 12:
                            foreach (var a in File_H01.find_default_group_face_images01())
                            {
                                data01[2] += $"{a}\n";
                            }
                     
                            Console.WriteLine(data01[2]);


                            break;
                        case 13:

                            data01[2] = $"{File_H01.all_embedded_safetensors_models()}\n";
                            Console.WriteLine(data01[2]);


                            break;

                        case 14:
                            foreach (var a in File_H01.all_text_to_text_gguf_models())
                            {
                                data01[2] += $"{a}\n";
                            }
                 
                            Console.WriteLine(data01[2]);
                            break;
                        case 15:
                            foreach (var a in File_H01.all_text_to_image_gguf_models())
                            {
                                data01[2] += $"{a}\n";
                            }
                
                            Console.WriteLine(data01[2]);
                            break;
                        case 16:
                            foreach (var a in File_H01.all_text_to_image_safetensors_models())
                            {
                                data01[2] += $"{a}\n";
                            }

                            Console.WriteLine(data01[2]);
                            break;
                        case 17:
                            foreach (var a in File_H01.all_python_files())
                            {
                                data01[2] += $"{a}\n";
                            }
               
                            Console.WriteLine(data01[2]);
                            break;
                        case 18:
                            foreach (var a in File_H01.all_text_to_text_gguf_models())
                            {
                                data01[2] += $"{a}\n";
                            }
                   
                            Console.WriteLine(data01[2]);
                            break;
                        case 19:
                            foreach (var a in File_H01.all_gguf_translate())
                            {
                                data01[2] += $"{a}\n";
                            }
           
                            Console.WriteLine(data01[2]);
                            break;
                        case 20:
                            foreach (var a in File_H01.all_saved_audio())
                            {
                                data01[2] += $"{a}\n";
                            }
                 
                            Console.WriteLine(data01[2]);
                            break;
                        case 21:
                            data01[2] = $"{File_H01.all_embedded_files01()}\n";
                            Console.WriteLine(data01[2]);
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

