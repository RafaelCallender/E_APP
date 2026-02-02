
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using System.Reflection;
namespace E_APP.SERVICES.FILE_SERVICES.TEXT_FILES
{
    internal class Read_Textfiles
    {
        private static File_Helper01 File_H01= new File_Helper01();
        private static string[] file_helper= File_H01.all_embedded_textfiles().Split();

        private static Assembly assembly = Assembly.GetExecutingAssembly();
        private static Stream[] stream01 = { assembly.GetManifestResourceStream(file_helper[0]),
                                             assembly.GetManifestResourceStream(file_helper[1]),
                                             assembly.GetManifestResourceStream(file_helper[2]),
                                             assembly.GetManifestResourceStream(file_helper[3]),
                                             assembly.GetManifestResourceStream(file_helper[4]),
                                             assembly.GetManifestResourceStream(file_helper[5]),
                                             assembly.GetManifestResourceStream(file_helper[6]),
                                             assembly.GetManifestResourceStream(file_helper[7]),
                                             assembly.GetManifestResourceStream(file_helper[8]),
                                             assembly.GetManifestResourceStream(file_helper[9]),
                                             assembly.GetManifestResourceStream(file_helper[10]),




        };
        private static StreamReader[] reader01 = { new StreamReader(stream01[0]),
                                                   new StreamReader(stream01[1]),
                                                   new StreamReader(stream01[2]),
                                                   new StreamReader(stream01[3]),
                                                   new StreamReader(stream01[4]),
                                                   new StreamReader(stream01[5]),
                                                   new StreamReader(stream01[6]),
                                                   new StreamReader(stream01[7]),
                                                   new StreamReader(stream01[8]),
                                                   new StreamReader(stream01[9]),
                                                   new StreamReader(stream01[10]),


        };
        private static string[] data01 = { reader01[0].ReadToEnd(),
                                           reader01[1].ReadToEnd(),
                                           reader01[2].ReadToEnd(),
                                           reader01[3].ReadToEnd(),
                                           reader01[4].ReadToEnd(),
                                           reader01[5].ReadToEnd(),
                                           reader01[6].ReadToEnd(),
                                           reader01[7].ReadToEnd(),
                                           reader01[8].ReadToEnd(),
                                           reader01[9].ReadToEnd(),
                                           reader01[10].ReadToEnd(),




        };
        private static string[] folder = { @"C:\Users\calle\OneDrive\Desktop\PROJECTS\E_APP\E_APP\bin\FILES\TEXT\TEXT_SAVED" };
        private static string[] files = Directory.GetFiles(folder[0],"*.*",SearchOption.AllDirectories);
        public string[] API => data01[0].Split("\n");
        public string[] Chemistry => data01[1].Split("\n");
        public string[] Chemistry01 => data01[2].Split("\n");
        public string[] cloudinary_com => data01[3].Split("\n");
        public string[] hairstyle_info_01 => data01[4].Split("\n");
        public string[] hairstyle_info_02 => data01[5].Split("\n");
        public string[] Language_Abbreviation => data01[6].Split("\n");
        public string[] Language_Name => data01[7].Split("\n");
        public string The_Book_of_Enoch => string.Join("\n", data01[8]);
        public string The_Book_of_Jubilees => string.Join("\n", data01[9]);

        public string The_Bible_KJV => string.Join("\n", data01[10]);
       public string Life_text_to_text_recordings_path => files[0];
        public string Life_voice_to_text_recordings_path => files[1];   
        public string life_voice_recordings_path => files[2];       

    }
}

