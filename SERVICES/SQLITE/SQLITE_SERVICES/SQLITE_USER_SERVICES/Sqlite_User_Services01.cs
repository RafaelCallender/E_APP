using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_USER__MANAGER;


namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_USER_SERVICES
{
    internal class Sqlite_User_Services01
    {
        private static string[] data01 = new string[100];

        public async Task<string> insert_user(string input01, string input02, string input03,
                                          string input04, string input05, string input06,
                                          string input07)
        {
            if (Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Insert(
                    new Sqlite_User_Get_Model01
                    {

                        username = input01,
                        firstname = input01,
                        lastname = input01,
                        birthdate = input01,
                        email = input01,
                        phonenumber = input01,
                        password = input01,
                        longitude = input01,
                        latitude = input01,
                        creation_date = input01,
                        text_file = input01,
                        audio_file = input01,
                        image_file = input01,
                        video_file = input01,
                        text_file_creation_date = input01,
                        audio_file_creation_date = input01,
                        image_file_creation_date = input01,
                        video_file_creation_date = input01,
                    }) > 0)
            {
                return "Data Inserted Successfully";
            }
            else
            {
                return "Data Insertion Failed";
            }


        }
        public async Task<string> find_email_using_email(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.email}\n";
  
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
     
        }
        public async Task<string> find_email_using_username(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.email}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public async Task<string> find_phonenumber_using_email(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.phonenumber}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_phonenumber_using_username(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.phonenumber}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_phonenumber_using_phonenumber(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.phonenumber == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.phonenumber}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_user_location_using_email(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.longitude}\n" +
                            $"{sqlcomm.lastname}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }

        public async Task<string> find_user_location_using_username(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.longitude}\n" +
                            $"{sqlcomm.lastname}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_username_using_email(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.username}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_username_using_username(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.username}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_password_using_email(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.password}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
        public async Task<string> find_password_using_username(string input)
        {
            var sqlcomm = Sqlite_User_Manager01.data01[(int)Sqlite_User_Manager01.command_strings.User01].Table<Sqlite_User_Get_Model01>()
                          .Where(i => i.username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.password}\n";

                return data01[0];
            }
            else
            {
                data01[0] = "Data Not Found";
                return data01[0];
            }
        }
    }
}
