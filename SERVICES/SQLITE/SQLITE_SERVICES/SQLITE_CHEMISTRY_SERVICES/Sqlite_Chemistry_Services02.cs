using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_SCIENCE_MANAGER.SQLITE_CHEMISTRY_MANAGER;


namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CHEMISTRY_SERVICES
{
    internal class Sqlite_Chemistry_Services02
    {

        private static string[] data01 = new string[100];

        public async Task<(bool sucess, string output)> insert_element(int input01, string input02, string input03,
                                             double input04, int input05, int input06,
                                             int input07)
        {
            var existing = Sqlite_Chemistry_Manager01.data01
        .Table<Sqlite_Chemistry_Get_Model01>()
        .FirstOrDefault(x => x.atomic_number == input01);

            if (existing != null)
            {
                return (false, "Data already exists");
            }
            else
            {
                if (Sqlite_Chemistry_Manager01.data01.Insert(
               new Sqlite_Chemistry_Get_Model01
               {
                   atomic_number = input01,
                   element_name = input02,
                   element_symboles = input03,
                   atomic_mass = input04,
                   protons = input05,
                   electons = input06,
                   neutrons = input07
               }) > 0)
                {

                    return (true, "Data Inserted Successfully");
            
                }
                else
                {
                    return (false, $"Data Not Found");
              
                }
            }


        }
        public async Task<(bool sucess, string output)> find_element_using_atomic_number(int input)
        {
            var data02 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>()
                .Where(i => i.atomic_number == input).FirstOrDefault();
            if (data02 != null)
            {
   
                return (true, $"{data02.atomic_number.ToString()}\n" +
                              $"{data02.element_name}\n" +
                              $"{data02.element_symboles}\n" +
                              $"{data02.atomic_mass.ToString()}\n" +
                              $"{data02.protons.ToString()}\n" +
                              $"{data02.electons.ToString()}\n" +
                              $"{data02.neutrons.ToString()}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool sucess, string output)> find_element_using_symbol(string input)
        {
            var data03 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>()
                .Where(i => i.element_symboles == input).FirstOrDefault();
            if (data03 != null)
            {
                return (true, $"{data03.atomic_number.ToString()}\n" +
                                  $"{data03.element_name}\n" +
                                  $"{data03.element_symboles}\n" +
                                  $"{data03.atomic_mass.ToString()}\n" +
                                  $"{data03.protons.ToString()}\n" +
                                  $"{data03.electons.ToString()}\n" +
                                  $"{data03.neutrons.ToString()}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool sucess, string output)> find_element_using_name(string input)
        {
            var data04 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>()
                .Where(i => i.element_name == input).FirstOrDefault();
            if (data04 != null)
            {
                return (true, $"{data04.atomic_number.ToString()}\n" +
                                       $"{data04.element_name}\n" +
                                       $"{data04.element_symboles}\n" +
                                       $"{data04.atomic_mass.ToString()}\n" +
                                       $"{data04.protons.ToString()}\n" +
                                       $"{data04.electons.ToString()}\n" +
                                       $"{data04.neutrons.ToString()}\n");
            }
            else
            {
                return (false, $"Data Not Found");
            }
        }
        public async Task<(bool sucess, string output)> view_all_elements()
        {
            var data05 = Sqlite_Chemistry_Manager01.data01.Table<Sqlite_Chemistry_Get_Model01>().ToList();
            foreach (var a in data05)
            {
                return (true, $"{a.atomic_number.ToString()}\n" +
                                         $"{a.element_name}\n" +
                                         $"{a.element_symboles}\n" +
                                         $"{a.atomic_mass.ToString()}\n" +
                                         $"{a.protons.ToString()}\n" +
                                         $"{a.electons.ToString()}\n" +
                                         $"{a.neutrons.ToString()}\n");
      
            }
            return (false, $"Data Not Found");
        }
    }
}
