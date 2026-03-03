using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;

namespace E_APP.SERVICES.FILE_SERVICES.AUIDO_FILES
{
    internal class Read_Audio_fFiles01
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string[] file_helper = File_H01.all_embedded_audio_files().Split();
        public string[] audio_files01 => file_helper;
    }
}

