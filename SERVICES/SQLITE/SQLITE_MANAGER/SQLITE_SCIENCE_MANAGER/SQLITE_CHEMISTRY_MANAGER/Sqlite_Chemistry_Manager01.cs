using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using SQLite;
using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;

namespace E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_SCIENCE_MANAGER.SQLITE_CHEMISTRY_MANAGER
{
    internal class Sqlite_Chemistry_Manager01
    {


        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Chemistry01.db"),
                                          Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Chemistry02.db")

        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0]),
                                                 new SQLiteConnection(dbPath[1])

        };

        static Sqlite_Chemistry_Manager01()
        {
            db[0].CreateTable<Sqlite_Chemistry_Get_Model01>();
            db[1].CreateTable<Sqlite_Chemistry_Get_Model02>();
        }

        public static SQLiteConnection data01 = db[0];
        public static SQLiteConnection data02 = db[1];


    }
}
