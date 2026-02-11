using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_EMAIL_MODEL;
using SQLite;


namespace E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_EMAIL_SERVICES
{
    internal class Sqlite_Email_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"EMAIL01.db"),
                                       

        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0]),
                                                

        };

        static Sqlite_Email_Manager01()
        {
            db[0].CreateTable<Sqlite_Email_Model01>();
   
        }

        public static SQLiteConnection data01 = db[0];
        public enum command_strings
        {
            EMAIL01 = 0,


        }


    }
}
