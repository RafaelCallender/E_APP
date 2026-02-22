
using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_CHEMISTRY_MODEL.SQL_CHEMISTRY_GET_MODEL;
using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_USER_MODEL.SQL_USER_GET_MODEL;
using E_APP.SERVICES.DEVICE_SERVICES;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_USER;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.Data.SqlClient;
using System.Data;
namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES
{
    internal class Sql_Services01
    {

        private static string[] data01 = new string[100];
        private static Device_Services01 Device_Serv01 = new Device_Services01();
        private bool status = false;
        private List<Sql_Get_Model01> collectiondata01 = new List<Sql_Get_Model01>();
        private List<string> usernames = new List<string>();
        private List<string> phonenumber = new List<string>();
        private List<string> email = new List<string>();

        private List<string> passwords = new List<string>();

        public bool insert_user(string input01, string input02, string input03,
                                          string input04, string input05, string input06,
                                          string input07, out string output)
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
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@phonenumber ", input06);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@password", input07);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@longitude", results[0]);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@latitude", results[1]);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@creation_date", data01[0]);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@text_file", " ");
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@audio_file", " ");
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@image_file", " ");
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@video_file", " ");
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@text_file_creation_date", data01[0]);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@audio_file_creation_date", data01[0]);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@image_file_creation_date", data01[0]);
                Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].Parameters.AddWithValue("@video_file_creation_date", data01[0]);


            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_email_using_email(string input, out string output)
        {

            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;

        }

        public bool find_email_using_username(string input, out string output)
        {

            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_phonenumber_using_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_phonenumber_using_username(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_phonenumber_using_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].Parameters.AddWithValue("@phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_phonenumber].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_location_using_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["latitude"].ToString()}" +
                                $"{reader["longitude"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = true;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_location_using_username(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["latitude"].ToString()}" +
                                $"{reader["longitude"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_username_using_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["username"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_username_using_username(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_password_using_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["password"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_password_using_username(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_password_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["password"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool insert_user_audio_file_using_username(string input, string input01, out string output)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].Parameters.AddWithValue("@audio_file", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].Parameters.AddWithValue("@audio_creation_date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_audio_file_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool insert_user_text_file_using_username(string input, string input01, out string output)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].Parameters.AddWithValue("@text_file", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].Parameters.AddWithValue("@text_creation_date", data01[0]);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_user_text_file_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool user_login(string input, string input01, out string output)
        {
            DateTime dateTime = DateTime.Now;
            data01[0] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.user_login].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.user_login].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.user_login].Parameters.AddWithValue("@password", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.user_login].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_email_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_email_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["email"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_phonenumber_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_phonenumber_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_user_location_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["longitude"].ToString()}\n" +
                       $"{reader["latitude"].ToString()}\n";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
      

            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_user_location_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_user_location_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["longitude"].ToString()}\n" +
                             $"{reader["latitude"].ToString()}\n";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_username_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].Parameters.AddWithValue("@email", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["username"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_usernmae_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_usernmae_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_usernmae_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_usernmae_using_username].Parameters.AddWithValue("@username", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_usernmae_using_username].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["username"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool update_user_location_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.AddWithValue("@longitude", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_user_location_using_name(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@firstname", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@lastname", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@longitude", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_name].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_user_location_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.AddWithValue("@phonenumber", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.AddWithValue("@longitude", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_phonenumber].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_user_location_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.AddWithValue("@longitude", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].Parameters.AddWithValue("@latitude", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_user_location_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_email_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].Parameters.AddWithValue("@email", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_email_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].Parameters.AddWithValue("@email", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_email_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_password_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].Parameters.AddWithValue("@password", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_password_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].Parameters.AddWithValue("@phonenumber", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].Parameters.AddWithValue("@passwordl", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_phonenumber].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_password_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].Parameters.AddWithValue("@passwordl", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_password_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_phonenumber_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].Parameters.AddWithValue("@phonenumber", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_phonenumber_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].Parameters.AddWithValue("@username", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].Parameters.AddWithValue("@phonenumber", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_phonenumber_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_username_using_email(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].Parameters.AddWithValue("@username", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_username_using_phonenumber(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].Parameters.AddWithValue("@email", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_phonenumber].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool update_username_using_username(string input, string input01, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].Parameters.AddWithValue("@email", input);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].Parameters.AddWithValue("@email", input01);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.update_username_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_user_using_email(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].Parameters.AddWithValue("@email", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_email].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_user_using_phonenumber(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].Parameters.AddWithValue("@email", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_phonenumber].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool delete_user_using_username(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].Parameters.AddWithValue("@email", input);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.delete_user_using_username].ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }
            else
            {
                output = "fail";
                status = false;
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
    
        public bool find_username_password(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].Parameters.AddWithValue("@phonenumber", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_username_password].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["phonenumber"].ToString()}";
                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;
                }
            }
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public string view_all_username()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_username].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_username].ExecuteReader())
            {
                while (reader.Read())
                {

                    usernames.Add(reader["username"]?.ToString() ?? string.Empty);
                    data01[0] += $"{reader["atomic_number"]?.ToString() ?? string.Empty}\n";
                    var collection_set = new Sql_Get_Model01
                    {

                        username = reader["username"]?.ToString() ?? string.Empty
                    };
                    collectiondata01.Add(collection_set);


                }
                foreach (var a in usernames)
                {
                    data01[0] += $"{a}\n";
                }



                return data01[0];
            }
        }
        public string view_all_passwords()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_password].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_password].ExecuteReader())
            {
                while (reader.Read())
                {

                    passwords.Add(reader["password"]?.ToString() ?? string.Empty);
                    data01[0] += $"{reader["password"]?.ToString() ?? string.Empty}\n";
                    var collection_set = new Sql_Get_Model01
                    {

                        password = reader["password"]?.ToString() ?? string.Empty
                    };
                    collectiondata01.Add(collection_set);


                }
                foreach (var a in usernames)
                {
                    data01[0] += $"{a}\n";
                }



                return data01[0];
            }
        }
    
        public string view_all_email()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_email].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_email].ExecuteReader())
            {
                while (reader.Read())
                {

                   email.Add(reader["email"]?.ToString() ?? string.Empty);
                    data01[0] += $"{reader["email"]?.ToString() ?? string.Empty}\n";
                    var collection_set = new Sql_Get_Model01
                    {

                        email = reader["email"]?.ToString() ?? string.Empty
                    };
                    collectiondata01.Add(collection_set);


                }
                foreach (var a in email)
                {
                    data01[0] += $"{a}\n";
                }



                return data01[0];
            }
        }
        public string view_all_phonenumber()
        {
            collectiondata01.Clear();
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_phonenumber].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_phonenumber].ExecuteReader())
            {
                while (reader.Read())
                {

                    phonenumber.Add(reader["phonenumber"]?.ToString() ?? string.Empty);
                    data01[0] += $"{reader["phonenumber"]?.ToString() ?? string.Empty}\n";
                    var collection_set = new Sql_Get_Model01
                    {

                       phonenumber = reader["phonenumber"]?.ToString() ?? string.Empty
                    };
                    collectiondata01.Add(collection_set);


                }
                foreach (var a in phonenumber)
                {
                    data01[0] += $"{a}\n";
                }



                return data01[0];
            }
        }
    }
}

  