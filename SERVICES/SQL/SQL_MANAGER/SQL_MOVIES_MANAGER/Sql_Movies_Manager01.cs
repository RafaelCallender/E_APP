using Microsoft.Data.SqlClient;

namespace E_APP.SERVICES.SQL.SQL_MANAGER.SQL_MOVIES_MANAGER
{
    internal class Sql_Movies_Manager01
    {
        private static string[] connectionString_ = {
@"Data Source=(localdb)\ProjectModels;
Initial Catalog=Movies_Database;
Integrated Security=True;
Connect Timeout=30;
Encrypt=True;
TrustServerCertificate=False;
ApplicationIntent=ReadWrite;
MultiSubnetFailover=False;
Command Timeout=30"
 };
        private static SqlConnection[] conn_ = { new SqlConnection(connectionString_[0]) };
        private static SqlCommand[] cmd_ = { new SqlCommand("insert_movies", conn_[0]),                 // 0
                                             new SqlCommand("find_location_using_file_name", conn_[0]),    // 1 
                                             new SqlCommand("find_file_name_using_file_location", conn_[0]),// 2
                                             new SqlCommand("view_all_movies", conn_[0]),// 3
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
            insert_movies = 0,
            find_location_using_file_name = 1,
            find_file_name_using_file_location = 2,
            view_all_movies = 3
        }
    }
}