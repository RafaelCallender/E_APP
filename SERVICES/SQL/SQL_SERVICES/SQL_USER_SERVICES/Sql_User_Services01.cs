
using E_APP.SERVICES.DEVICE_SERVICES;
using Microsoft.Data.SqlClient;
using System.Data;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_USER;
namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES
{
    internal class Sql_Services01
    {

        private static string[] data01 = new string[3];
        private static Device_Services01 Device_Serv01 = new Device_Services01();
        public static async Task<string> insert_user(string input01, string input02, string input03,
                                          string input04, string input05, string input06,
                                          string input07)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string[] results = Device_Serv01.get_device_ip().Result.Split(',');
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@username", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@firstname", input02);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@lastname", input03);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@birthdate", input04);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@email", input05);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@phonenumber", input06);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@password", input07);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@longitude", results[0]);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@latitude", results[1]);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@creation_date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].ExecuteNonQuery();
            if (Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].ExecuteNonQuery() == null)
            {
                if (rowsAffected > 0)
                {
                    data01[1] = "sucess";
                }

                else
                {
                    data01[1] = "fail";
                }
            }
            else
            {
                data01[1] = "error";
            }
            Sql_Manager01.conn[2].Close();
            return data01[1];

        }
        public string find_email_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["email"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];

        }

        public  string find_email_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["email"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_phonenumber_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_phonenumber_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public  string find_phonenumber_using_phonenumber(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].Parameters.AddWithValue("@phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_user_location_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["latitude"].ToString()}" +
                                $"{reader["longitude"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_user_location_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["latitude"].ToString()}" +
                                $"{reader["longitude"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_username_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["username"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_username_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["phonenumber"].ToString()}";

                }
                else
                {
                    data01[0] = "cant find";

                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public  string find_password_using_email(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["password"].ToString()}";
                }
                else
                {
                    data01[0] = "cant find";
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }
        public  string find_password_using_username(string input)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] = $"{reader["password"].ToString()}";
                }
                else
                {
                    data01[0] = "cant find";
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];
        }

        public string insert_user_audio_file_using_username(string input,string input01)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].Parameters.AddWithValue("@audio_file", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].Parameters.AddWithValue("@audio_creation_date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].ExecuteNonQuery();
            if (Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].ExecuteNonQuery() == null)
            {
                if (rowsAffected > 0)
                {
                    data01[1] = "sucess";
                }

                else
                {
                    data01[1] = "fail";
                }
            }
            else
            {
                data01[1] = "error";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[1];

        }
        public string insert_user_text_file_using_username(string input, string input01)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].Parameters.AddWithValue("@text_file", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].Parameters.AddWithValue("@text_creation_date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].ExecuteNonQuery();
            if (Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].ExecuteNonQuery() == null)
            {
                if (rowsAffected > 0)
                {
                    data01[1] = "sucess";
                }

                else
                {
                    data01[1] = "fail";
                }
            }
            else
            {
                data01[1] = "error";
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[1];

        }
    }
}
