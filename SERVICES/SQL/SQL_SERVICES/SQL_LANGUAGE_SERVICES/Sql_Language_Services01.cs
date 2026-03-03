using Microsoft.Data.SqlClient;
using System.Data;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_LANGUAGE;
namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES
{
    internal class Sql_Language_Services01
    {
        private bool status = false;
        private static string[] data01 = new string[3];
        private List<string> code = new List<string>();
        private List<string> language = new List<string>();
        public string[] data_array = {
                                      "Language Code",//0
                                      "Language name",//1
                                      "select language",//2
        
        };
        public bool insert_language(string input01, string input02, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].Parameters.AddWithValue("@code", input01);
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].Parameters.AddWithValue("@language", input02);
            int rowsAffected = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                output = "sucess";
                status = true;
            }

            else
            {
               output = "fail";
            status= false;      
            }

            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_code_using_code(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_code].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_code].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_code].Parameters.AddWithValue("@code", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_code].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
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
        public bool find_code_using_language(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_language].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_language].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_language].Parameters.AddWithValue("@language", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_code_using_language].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
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
        public bool find_language_using_code(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_language_using_code].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_language_using_code].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_language_using_code].Parameters.AddWithValue("@code", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["language"].ToString()}";
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
        public bool find_language_using_Language(string input, out string output)
        {
            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_language_using_Language].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_language_using_Language].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.find_language_using_Language].Parameters.AddWithValue("@language", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.insert_language].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["language"].ToString()}";
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
        public string view_all_data_from_language_table()
        {


            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Open();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_data_from_language_table].Parameters.Clear();
            Sql_Manager01.cmd[(int)Sql_Manager01.command_strings.view_all_data_from_language_table].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[22].ExecuteReader())
            {
                while (reader.Read())
                {

                    data01[0] += $"{reader["code"]}\n" +
                                 $"{reader["language"]}\n";
                    code.Add(reader["code"]?.ToString() ?? string.Empty);
                    language.Add(reader["language"]?.ToString() ?? string.Empty);
                }
            }
            data01[1] += $"{string.Join(" ", code)}\n" +
                         $"{string.Join(" ", language)}\n";

            Sql_Manager01.conn[(int)Sql_Manager01.Connection_strings.Connection01].Close();
            return data01[0];

        }

    }
}