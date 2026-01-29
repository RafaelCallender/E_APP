using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_USER__MANAGER;

namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_USER_SERVICES
{
    internal class Sqlite_User_Services03
    {
        private static string[] data01 = new string[100];
        public async Task<string> insert_user_audio_file_using_username(string input, string input1)
        {
            if (Sqlite_User_Manager01.data01[1].Insert(
                new Sqlite_User_Get_Model03
                {
                    username = input,
                    audio_file = input1,
                    audio_creation_date = DateTime.Now
                        .ToString("yyyy-MM-dd HH:mm:ss")
                }) > 0)
            {
                return "Text File Inserted Successfully";
            }
            return data01[0];
        }
    }
}