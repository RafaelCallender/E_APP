using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_USER__MANAGER;
namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_USER_SERVICES
{
    internal class Sqlite_User_Services04
    {
        private static string[] data01 = new string[100];
        public async Task<string> insert_user_video_file_using_username(string input, string input1)
        {

            if (Sqlite_User_Manager01.data01[2].Insert(
                new Sqlite_User_Get_Model04
                {
                    username = input,
                    video_file = input1,
                    video_creation_date = DateTime.Now
                        .ToString("yyyy-MM-dd HH:mm:ss")
                }) > 0)
            {
                return "Text File Inserted Successfully";
            }
            return data01[0];
        }

        public async Task<string> find_user_video_file_using_username(string input)
        {
            var files = Sqlite_User_Manager01.data01[2]
                .Table<Sqlite_User_Get_Model04>()
                .Where(i => i.username == input)
                .ToList();

            if (files != null && files.Count > 0)
            {


                foreach (var a in files)
                {

                    data01[0] = $"{a.video_file}\n" +
                                $"{a.video_creation_date}";
                   
                }

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
    }
}