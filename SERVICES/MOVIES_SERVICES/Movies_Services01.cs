using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_MOVIES_SERVICES;
using E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_MOIVES_SERVICES;
namespace E_APP.SERVICES.MOVIES_SERVICES
{
    internal class Movies_Services01
    {
        private static string[] data01 = new string[100];
       private static Sql_Movie_Services01 Sql_Movie_Serv01= new Sql_Movie_Services01();
        private static Sqlite_Movies_Services01 Sqlite_Movies_Serv01 = new Sqlite_Movies_Services01();  
        private List<string> File_Location = new List<string>();
        private List<string> File_name = new List<string>();

        public Movies_Services01()  
        {
            load_movie_data();
        }
        public string get_all_movies()
        {
            return data01[0];
        }
        private void load_movie_data()
        {
            for (int i = 0; i < File_Location.Count; i++)
            {
                data01[0] += Sql_Movie_Serv01.insert_movies(File_Location[i], File_name[i]);
                data01[1] += Sqlite_Movies_Serv01.insert_movies(File_Location[i], File_name[i]);
            }
       
        }
    }
}
