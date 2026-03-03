using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_MOVIES_SERVICES;
using E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_MOIVES_SERVICES;
using System.Threading.Tasks;
namespace E_APP.SERVICES.MOVIES_SERVICES
{
    internal class Movies_Services01
    {
  
        private string output = "";
        private static string[] data01 = new string[100];
        private static Sql_Movie_Services01 Sql_Movie_Serv01 = new Sql_Movie_Services01();
        private static Sqlite_Movies_Services01 Sqlite_Movies_Serv01 = new Sqlite_Movies_Services01();
        private List<string> File_Location = new List<string>();
        private List<string> File_name = new List<string>();
        private string[] data_array = { "Super Hero Movies","history",
                                        "Denzel Washinton Movies",
                                        "Western Movies",
                                        "Space Movies",
                                        "Comedy",
                                        "Horror",
                                        "Star Wars Movies",
                                        "Preditor and alien Movies"};

        public Movies_Services01()
        {
            load_movie_data().Wait();
        }
        public string get_all_movies()
        {
            return data01[0];
        }
        private async Task load_movie_data()
        {


        }

    }
}
