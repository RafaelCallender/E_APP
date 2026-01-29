using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_MOVIES_MODEL.SQLITE_MOVIES_GET_MODEL;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_SCIENCE_MANAGER.SQLITE_CHEMISTRY_MANAGER;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQSLITE_MOVIES_MANAGER;


namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_MOIVES_SERVICES
{
    internal class Sqlite_Movies_Services01
    {
        private static string[] data01 = new string[100];
        public async Task<string> insert_movies(string input01, string input02)
        {
            var existing = Sqlite_Movies_Manager01.data01
.Table<Sqlite_Movies_Get_Model01>()
.FirstOrDefault(x => x.file_location == input01);

            if (existing != null)
            {
                return "Data already exists";
            }
            else
            {
                if (Sqlite_Movies_Manager01.data01.Insert(
                    new Sqlite_Movies_Get_Model01
                    {
                        file_location = input01,
                        file_name = input02

                    }) > 0)
                {
                    return "Data Inserted Successfully";
                }
                else
                {
                    return "Data Insertion Failed";
                }
            }

        }
        public async Task<string> find_location_using_file_name(string input)
        {

            var data02 = Sqlite_Movies_Manager01.data01.Table<Sqlite_Movies_Get_Model01>()
                .Where(i => i.file_location == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.file_location}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> find_name_using_file_loaction(string input)
        {

            var data02 = Sqlite_Movies_Manager01.data01.Table<Sqlite_Movies_Get_Model01>()
                .Where(i => i.file_location == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.file_location}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> view_all_movies_using_sql(string input)
        {

            var data05 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>().ToList();
            foreach (var a in data05)
            {
                data01[3] += $"{a.atomic_number}\t" +
                             $"{a.element_name}\t" +
                             $"{a.element_symboles}\t" +
                             $"{a.atomic_mass}\t" +
                             $"{a.protons}\t" +
                             $"{a.electons}\t" +
                             $"{a.neutrons}\n";
            }
            return data01[3];
        }

    }
}
