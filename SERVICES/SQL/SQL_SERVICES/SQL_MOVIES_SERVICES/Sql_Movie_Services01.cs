using E_APP.SERVICES.SQL.SQL_MANAGER.SQL_MOVIES_MANAGER;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_MOVIES_SERVICES
{
    internal class Sql_Movie_Services01
    {
        private bool status = false;

        private static string[] data01 = new string[100 ];
        private List<string> File_Location = new List<string>();
        private List<string> File_Name = new List<string>();
        public string[] data_array = {
                                      "view all Movies using SQL",//0
                                      "find movies using SQL",//1
                                      "view all Movies using SQLITE" };//2
        public bool insert_movies(string input01, string input02,out string output)
        {

            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Open();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.insert_movies].Parameters.Clear();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.insert_movies].CommandType = CommandType.StoredProcedure;
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.insert_movies].Parameters.AddWithValue("@file_location", input01);
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.insert_movies].Parameters.AddWithValue("@file_name", input02);
            int rowsAffected = Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.insert_movies].ExecuteNonQuery();

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

            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_location_using_file_name(string input, out string output)
        {
            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Open();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_location_using_file_name].CommandType = CommandType.StoredProcedure;
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_location_using_file_name].Parameters.Clear();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_location_using_file_name].Parameters.AddWithValue("@file_name", input);
            using (SqlDataReader reader = Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_location_using_file_name].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["file_name"].ToString()}";

                    status = true;
                }
                else
                {
                    output = "cant find";
                    status = false;

                }
            }
            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_name_using_file_loaction(string input, out string output)
        {
            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Open();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_file_name_using_file_location].CommandType = CommandType.StoredProcedure;
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_file_name_using_file_location].Parameters.Clear();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_file_name_using_file_location].Parameters.AddWithValue("@file_location", input);
            using (SqlDataReader reader = Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.find_file_name_using_file_location].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["file_location"].ToString()}";
                    status = true;

                }
                else
                {
                output = "cant find";
                    status = false;
                }
            }
            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public string view_all_movies_using_sql()
        {
            File_Location.Clear();
            File_Name.Clear();
            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Open();
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.view_all_movies].CommandType = CommandType.StoredProcedure;
            Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.view_all_movies].Parameters.Clear();
            using (SqlDataReader reader = Sql_Movies_Manager01.cmd[(int)Sql_Movies_Manager01.command_strings.view_all_movies].ExecuteReader())
            {
                while (reader.Read())
                {
                    File_Location.Add(reader["file_location"]?.ToString() ?? string.Empty);
                    File_Name.Add(reader["file_name"]?.ToString() ?? string.Empty);
                }
            }
            Sql_Movies_Manager01.conn[(int)Sql_Movies_Manager01.Connection_strings.Connection01].Close();
            data01[0] = string.Join(",", File_Location);
            data01[1] = string.Join(",", File_Name);
            return $"{data01[0]}|{data01[1]}";
        }
    }
}