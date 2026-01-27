

namespace E_APP.SERVICES.MOVIES_SERVICES
{
    internal class Movies_Services01
    {
        private static string[] data01 = new string[100];
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

        }
    }
}
