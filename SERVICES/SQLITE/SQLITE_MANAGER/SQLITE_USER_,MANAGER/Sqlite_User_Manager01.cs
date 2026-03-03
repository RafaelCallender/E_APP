using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL;
using SQLite;


namespace E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_USER__MANAGER
{

    internal class Sqlite_User_Manager01
    {
        private static string[] dbPath ={ Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"User01.db"),//user info
                                          Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"User02.db"),//user text file
                                          Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"User03.db"),//user audio file
                                          Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"User04.db"),//user video file


        };
        private static SQLiteConnection[] db = { new SQLiteConnection(dbPath[0]),
                                                 new SQLiteConnection(dbPath[1]),
                                                 new SQLiteConnection(dbPath[2]),
                                                 new SQLiteConnection(dbPath[3]),

        };

        static Sqlite_User_Manager01()
        {
            db[0].CreateTable<Sqlite_User_Get_Model01>();
            db[1].CreateTable<Sqlite_User_Get_Model02>();
            db[2].CreateTable<Sqlite_User_Get_Model03>();
            db[3].CreateTable<Sqlite_User_Get_Model04>();

        }

        public static SQLiteConnection[] data01 = { db[0],
                                                    db[1],
                                                    db[2],
                                                    db[3]


        };
        public enum command_strings
        {
            User01=0,
            User02=1,   
            User03=2,
            User04=3,

        }


    }
}
