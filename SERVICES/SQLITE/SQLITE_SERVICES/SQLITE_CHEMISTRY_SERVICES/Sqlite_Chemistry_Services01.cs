using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_SCIENCE_MANAGER.SQLITE_CHEMISTRY_MANAGER;
using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;

namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CHEMISTRY_SERVICES
{
    internal class Sqlite_Chemistry_Services01
    {
        private static string[] data01 = new string[100];
        public async Task<string> insert_element_category(string input01, string input02, string input03,
                                                          string input04, string input05, string input06, string input07)
        {
            var existing = Sqlite_Chemistry_Manager01.data01
.Table<Sqlite_Chemistry_Get_Model02>()
.FirstOrDefault(x => x.Alkali_Metals == input01);

            if (existing != null)
            {
                return "Data already exists";
            }
            else
            {
                if (Sqlite_Chemistry_Manager01.data02.Insert(
                    new Sqlite_Chemistry_Get_Model02
                    {
                        Alkali_Metals = input01,
                        Alkaline_Earth_Metals = input02,
                        Transition_Metals = input03,
                        Lanthanides_Rare_Earth_Metals = input04,
                        Noble_Gases = input05,
                        Actinides = input06,
                        Nonmetal_Gases_at_Room_Temperature = input07,
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
        public async Task<string> find_Alkali_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Alkali_Metals == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> Find_Actinides(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Alkali_Metals == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> find_Alkaline_Earth_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Alkali_Metals == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> find_Lanthanides_Rare_Earth_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Lanthanides_Rare_Earth_Metals == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> find_Noble_Gases(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Noble_Gases == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> find_Nonmetal_Gases_at_Room_Temperature(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Nonmetal_Gases_at_Room_Temperature == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

        public async Task<string> find_Transition_Metals(string input)
        {

            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model02>()
                .Where(i => i.Transition_Metals == input).FirstOrDefault();
            if (data02 != null)
            {
                data01[0] = $"{data02.Alkali_Metals}\n";

                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }

    }
}
