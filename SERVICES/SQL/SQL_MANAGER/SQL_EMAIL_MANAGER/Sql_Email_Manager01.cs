using Microsoft.Data.SqlClient;


namespace E_APP.SERVICES.SQL.SQL_MANAGER.SQL_EMAIL_MANAGER
{
    internal class Sql_Email_Manager01
    {
        private static string[] connectionString_ = {
            @"Data Source=(localdb)\ProjectModels;
            Initial Catalog=Email_Database;
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=True;
            TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False;
            Command Timeout=30" };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = {
                            new SqlCommand("insert_email", conn_[0]),
                            new SqlCommand("find_email_using_email", conn_[0]),
                            new SqlCommand("find_email_using_name", conn_[0]),
                            new SqlCommand("find_email_using_phonenumber", conn_[0]),
                            new SqlCommand("find_full_name_using_email", conn_[0]),
                            new SqlCommand("find_full_name_using_full_name", conn_[0]),
                            new SqlCommand("find_full_name_using_phonenumber", conn_[0]),
                            new SqlCommand("find_phonenumber_using_email", conn_[0]),
                            new SqlCommand("find_phonenumber_using_fullname", conn_[0]),
                            new SqlCommand("find_phonenumber_using_phonenumber", conn_[0]),



        };

        public static SqlCommand[] cmd
        {
            get { return cmd_; }
            set { cmd_ = value; }
        }

        public static SqlConnection[] conn
        {
            get { return conn_; }
            set { conn_ = value; }
        }
        public enum Connection_strings
        {
            Connection01 = 0
        }
        public enum command_strings
        {
            insert_email = 0,
            find_email_using_email = 1,
            find_email_using_name = 2,
            find_email_using_phonenumber = 3,
            find_full_name_using_email = 4,
            find_full_name_using_full_name = 5,
            find_full_name_using_phonenumber = 6,
            find_phonenumber_using_email = 7,
            find_phonenumber_using_fullname = 8,
            find_phonenumber_using_phonenumber = 9,
        }


    }
}
