using E_APP.SERVICES.SQL.SQL_MANAGER.SQL_EMAIL_MANAGER;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES
{
    internal class Sql_Email_Services01
    {
        private bool status = false;
        public bool insert_email(string input01, string input02, string input03, string input04
            , out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue(" @full_name", input01);
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue(" @email", input02);
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@email_creation_date", input03);
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].Parameters.AddWithValue("@phone_number", input04);
            int rowsAffected = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.insert_email].ExecuteNonQuery();

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

            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_email_using_email(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
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
            return status;
        }


        public bool find_email_using_name(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@full_name", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
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
            return status;
        }
        public bool find_email_using_phonenumber(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@phone_number", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status = true;

                }
                else
                {
                    output = "cant find";
                    status=false;       
                }
            }
            return status;
        }


        public bool find_full_name_using_email(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status=true;    

                }
                else
                {
                   output= "cant find";
                    status = false;     
                }
            }
            return status;
        }
        public bool find_full_name_using_full_name(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@full_name", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status = true;      

                }
                else
                {
                    output = "cant find";
                    status=false;       
                }
            }
            return status;
        }

        public bool find_full_name_using_phonenumber(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@phone_number", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status=true;

                }
                else
                {
                    output = "cant find";
                    status = false;     
                }
            }
            return status;
        }
        public bool find_phonenumber_using_email(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@email", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["code"].ToString()}";
                    status = true;

                }
                else
                {
                   output = "cant find";
                    status &= false;        
                }
            }
            return status;
        }
        public bool find_phonenumber_using_fullname(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@full_name", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
            {
                if (reader.Read())
                {
                   output = $"{reader["code"].ToString()}";
                    status = true;     

                }
                else
                {
                   output = "cant find";
                    status |= false;        
                }
            }
            return status;
        }
        public bool find_phonenumber_using_phonenumber(string input01, out string output)
        {
            Sql_Email_Manager01.conn[(int)Sql_Email_Manager01.Connection_strings.Connection01].Open();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].CommandType = CommandType.StoredProcedure;
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.Clear();
            Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].Parameters.AddWithValue("@phone_number", input01);
            using (SqlDataReader reader = Sql_Email_Manager01.cmd[(int)Sql_Email_Manager01.command_strings.find_email_using_email].ExecuteReader())
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
            return status;
        }

    }
}
