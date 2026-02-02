using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.AUDIO_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;

namespace E_APP.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01=new Ai_Text_To_Text01();
        private static Read_Textfiles READ = new Read_Textfiles();

        public Life_Selection_View01()
        {
            load_Life_Selection_View01().Wait();
        }
        private async Task load_Life_Selection_View01()
        {

            data01[0] = $"1.) Read the Bible\n" +
                        $"2.) audio book of the Bible\n" +
                        $"3.) questions about the Bible\n" +
                        $"4.) record thoughts\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();


            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {

                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            data01[2] += $"{The_Bible_Serv01.read_full_bible_text()}\n";
                            Console.WriteLine(data01[2]);
                            break;
                        case 2:
                            data01[2] = The_Bible_Serv01.read_full_bible_text();
                            await Audio_Serv01.text_to_voice01(data01[2]);
                            Console.WriteLine(data01[2]);
                            break;
                        case 3:
                            data01[2] = "what questions about he bible your have";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                data01[4] = await Ai_Text_To_T01.text_to_text_content01(data01[3], The_Bible_Serv01.LoadBibleChunks);
                                Console.WriteLine(data01[4]);
                            }
                            else
                            {
                                data01[4] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[4]);
                            }

                            break;
                        case 4:
                            data01[2] = "Record Thoughts\n" +
                                "by\n" +
                                "1.) Type or write your thoughts\n" +
                                "2.) Speak your thoughts\n" +
                                "3.) listen to past recorded thoughts\n" +
                                "4.) read past recorded thoughts";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine();
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    switch (int.Parse(data01[3]))
                                    {
                                        case 1:
                                            data01[4] = "Type or write your thoughts below:";
                                            Console.WriteLine(data01[4]);
                                            data01[5] = Console.ReadLine();
                                            if (Security_Serv01.empty_string(data01[5]) == true)
                                            {

                                                string projectRoot =
               Directory.GetParent(AppContext.BaseDirectory)!
                        .Parent!
                        .Parent!
                        .FullName;

                                                string folder = Path.Combine(
                                                    projectRoot,
                                                    "FILES",
                                                    "TEXT",
                                                    "TEXT_SAVED"
                                                );

                                                // Ensure folder exists
                                                Directory.CreateDirectory(folder);

                                                // Save file
                                                string filePath = Path.Combine(folder, "thoughts.txt");
                                                File.AppendAllText(filePath, data01[5]);

                                                data01[6]=$"Saved to:\n{filePath}";
                                                Console.WriteLine(data01[6]);
                                            }
                                            else
                                            {
                                                data01[6] = "Input cannot be empty. Please try again.";
                                                Console.WriteLine(data01[6]);
                                            }
                                            break;
                                        case 2:

                                            string file01 = File_Helper01.save_files[(int)File_Helper01.saved_file_strings.AUDIOM_SAVED];
                                            data01[6] = $"Your thoughts have been recorded. Thank you!\n" +
                                                        $"{await Audio_Serv01.start_recording(file01)}\n" +
                                                        $"type 1 to stop\n";
                                       
                                            Console.WriteLine(data01[6]);
                                            data01[7] = Console.ReadLine();
                                            if (data01[7] == "1")
                                            {
                                                data01[8] = await Audio_Serv01.stop_recording();
                                                data01[9] = await Audio_Serv01.Convert_Speach_to_Text(data01[8]);


                                                Console.WriteLine(data01[9]);
                                            }
                                            else
                                            {
                                                data01[6] = "Input cannot be empty. Please try again.";
                                                Console.WriteLine(data01[6]);
                                            }
                                            break;
                                        case 3:
                                            data01[4] = $"{READ.Life_text_to_text_recordings_path}\n";
                                            Console.WriteLine(data01[4]);
                                            break;
                                        case 4:
                                            data01[4] = $"{READ.life_voice_recordings_path}\n";
                                            Console.WriteLine(data01[4]);
                                            break;
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[4]);
                                }
                            }
                            else
                            {
                                data01[4] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[4]);
                            }

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
