using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
using SQLite;


namespace E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQSLITE_MOVIES_MANAGER
{
    internal class Sqlite_Movies_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"MOVIES01.db"),
                                     

        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0])

        };

        static Sqlite_Movies_Manager01()
        {
            db[0].CreateTable<Sqlite_Chemistry_Get_Model01>();
 
        }

        public static SQLiteConnection data01 = db[0];

    }
}
